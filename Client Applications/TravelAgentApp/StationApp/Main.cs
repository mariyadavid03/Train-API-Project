using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Globalization;

namespace StationApp
{
    public partial class Main : Form
    {
        int scheduleId;
        int trainId;
        string selectedClassName;

        //

        string start;
        string end;
        string nic;
        string seats;

        public Main()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
   
            pnlBooking.Visible = false;
            pnlTrain.Visible = false;
            pnlSummary.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTrainInfo.Columns["dgvSelect"].Index && e.RowIndex >= 0)
            {
                
                string trainName = dgvTrainInfo.Rows[e.RowIndex].Cells["Train_Name"].Value.ToString();
                string trainNo = dgvTrainInfo.Rows[e.RowIndex].Cells["Train_No"].Value.ToString();
                string startTime = dgvTrainInfo.Rows[e.RowIndex].Cells["StartTime"].Value.ToString();
                string arrivalTime = dgvTrainInfo.Rows[e.RowIndex].Cells["ArrivalTime"].Value.ToString();
                string type = dgvTrainInfo.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                lbTrainNo.Text = startTime;
                lbTrainName.Text = arrivalTime;

                //summary
                lblTrainNo.Text = trainNo;
                lblTrainName.Text = trainName;
                lblStartTime.Text = startTime;
                lblArrivalTime.Text = arrivalTime;
                lblType.Text = type;

                pnlTrain.Visible = true;
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void NotAvaliablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string TrainDate = dtpTrainDate.Value.ToString("MM-dd-yyyy");
            string Start = txtStart.Text;
            string End = txtEnd.Text;

            string url = $"https://localhost:44387/api/Schedule/schedules?date={TrainDate}&startStation={Start}&endStation={End}";
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    List<SearchSchedule> schedules = (new JavaScriptSerializer())
                        .Deserialize<List<SearchSchedule>>(responseBody);
                    dgvTrainInfo.Rows.Clear();
                    if (schedules.Count > 0)
                    {
                        foreach (var schedule in schedules)
                        {
                            int train_id = schedule.TrainId;
                            string trainUrl = $"https://localhost:44387/api/Train/{train_id}?id={train_id}";

                            HttpResponseMessage trainResponse = await client.GetAsync(trainUrl);
                            if (trainResponse.IsSuccessStatusCode)
                            {
                                string trainResponseBody = await trainResponse.Content.ReadAsStringAsync();
                                Train train = (new JavaScriptSerializer()).Deserialize<Train>(trainResponseBody);

                                int rowIndex = dgvTrainInfo.Rows.Add();
                                dgvTrainInfo.Rows[rowIndex].Cells["Train_No"].Value = train.TrainNo;
                                dgvTrainInfo.Rows[rowIndex].Cells["Train_Name"].Value = train.TrainName;
                                dgvTrainInfo.Rows[rowIndex].Cells["Type"].Value = train.TrainType;
                                dgvTrainInfo.Rows[rowIndex].Cells["StartTime"].Value = schedule.StartTime;
                                dgvTrainInfo.Rows[rowIndex].Cells["ArrivalTime"].Value = schedule.ArrivalTime;
                                dgvTrainInfo.Rows[rowIndex].Cells["Train_Id"].Value = schedule.TrainId;
                                dgvTrainInfo.Rows[rowIndex].Cells["Schedule_Id"].Value = schedule.ScheduleId;

                                scheduleId = schedule.ScheduleId;
                                start = Start;
                                end = End;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No schedules found for the specified criteria.");
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBookTrain_Click(object sender, EventArgs e)
        {

            pnlBooking.Visible = true;
        }
        private async void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClassName = cbClass.SelectedItem.ToString();
            try
            {
                int selectedRowIndex = dgvTrainInfo.SelectedCells[0].RowIndex;
                trainId = Convert.ToInt32(dgvTrainInfo.Rows[selectedRowIndex].Cells["Train_Id"].Value);
                string className = selectedClassName;


                string totalSeatsUrl = $"https://localhost:44387/api/Class/TotalSeats?trainId={trainId}&className={className}";
                HttpClient client = new HttpClient();
                HttpResponseMessage totalSeatsResponse = await client.GetAsync(totalSeatsUrl);

                if (totalSeatsResponse.IsSuccessStatusCode)
                {
                    int totalSeats = await totalSeatsResponse.Content.ReadAsAsync<int>();
                    string bookedSeatNumbersUrl = $"https://localhost:44387/api/Seat/GetBookedSeatNumbers?trainId={trainId}&className={className}";
                    HttpResponseMessage bookedSeatNumbersResponse = await client.GetAsync(bookedSeatNumbersUrl);
                    
                    if (bookedSeatNumbersResponse.IsSuccessStatusCode)
                    {
                        List<int> bookedSeatNumbers = await bookedSeatNumbersResponse.Content.ReadAsAsync<List<int>>();

                        int availableSeatCount = totalSeats - bookedSeatNumbers.Count;
                        string availableSeatCountString = availableSeatCount.ToString();

                        //If no seats avaliable
                        if (availableSeatCount == 0)
                        {
                            lblAvaliableSeats.Text = "Full";
                        }
                        else
                        {
                            lblAvaliableSeats.Text = availableSeatCountString;
                        }

                        List<int> availableSeatNumbers = Enumerable.Range(1, totalSeats)
                                                                   .Except(bookedSeatNumbers)
                                                                   .ToList();

                        cbSeatNo.Items.Clear();
                        foreach (int seatNumber in availableSeatNumbers)
                        {
                            cbSeatNo.Items.Add(seatNumber);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {bookedSeatNumbersResponse.StatusCode}");
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {totalSeatsResponse.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }

        }
        private async void cbSeatNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnBook_Click(object sender, EventArgs e)
        {
            
            try
            {
                int trainID = trainId;
                string className = selectedClassName;
                int seatNo = Convert.ToInt32(cbSeatNo.SelectedItem.ToString());
                nic = Convert.ToString(txtNIC.Text);
                int scheduleID = scheduleId;

                string bookingUrl = "https://localhost:44387/api/Booking";
                string seatAssignUrl = "https://localhost:44387/api/Seat";

                HttpClient client = new HttpClient();
                Booking booking = new Booking();
                Seat seat = new Seat();

                booking.TrainId = trainID;
                booking.ScheduleId = scheduleID;
                booking.ClassName = className;
                booking.SeatNo = seatNo;
                booking.PassengerNIC = nic;

                seat.SeatNo = seatNo;
                seat.ClassName = className;
                seat.TrainId = trainID;
                seat.SeatStatus = "Booked";

                string data = (new JavaScriptSerializer()).Serialize(booking);
                var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");

                string dataSeat = (new JavaScriptSerializer()).Serialize(seat);
                var contentSeat = new StringContent(dataSeat, UnicodeEncoding.UTF8, "application/json");

                //checking if the nic is used more than 5 times
                if (!await CheckNICUsage(nic, trainID, scheduleID))
                {
                    MessageBox.Show("Booking limit of 5 exceeded for the passenger");
                    pnlBooking.Visible = false;
                    return;
                }


                var res = client.PostAsync(bookingUrl, content).Result;
                var resp = client.PostAsync(seatAssignUrl, contentSeat).Result;

                if (res.IsSuccessStatusCode && resp.IsSuccessStatusCode)
                {
                    var result = MessageBox.Show("Booking Added Successfully. Book again for the same passenger", "Booking Confirmation", MessageBoxButtons.YesNoCancel);
                    lblNic.Text = nic;
                    lblStartStation.Text = start;
                    lblEndStation.Text = end;
                   await ShowPassengerSeats(nic, trainID, scheduleID);

                    if (result == DialogResult.Yes)
                    {
                        pnlBooking.Visible = true;
                        pnlTrain.Visible = false;
                        pnlSummary.Visible = false;
                    }
                    else if (result == DialogResult.No)
                    {

                        pnlTrain.Visible = false;
                        pnlBooking.Visible = false;
                        pnlSummary.Visible = true;
                    }
                    

                }
                else
                {
                    MessageBox.Show("Booking Failed");
                    pnlBooking.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }

        }
        private async Task<bool> CheckNICUsage(string nic, int trainId, int scheduleId)
        {
            try
            {
                string url = $"https://localhost:44387/api/Booking/check/{nic}/{trainId}/{scheduleId}";
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return true; 
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
                return false;
            }
        }

        private async Task ShowPassengerSeats(string passengerNIC, int trainId, int scheduleId)
        {
            try
            {
                string url = $"https://localhost:44387/api/Booking/PassengerSeats?passengerNIC={passengerNIC}&trainId={trainId}&scheduleId={scheduleId}";
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    List<Seat> passengerSeats = await response.Content.ReadAsAsync<List<Seat>>();

                    if (passengerSeats.Count > 0)
                    {
                        StringBuilder seatInfoBuilder = new StringBuilder();
                        foreach (var seatInfo in passengerSeats)
                        {
                            seatInfoBuilder.AppendLine($"Seat {seatInfo.SeatNo} - {seatInfo.ClassName}");
                        }
                        lblSearInfo.Text = seatInfoBuilder.ToString();
                    }
                    else
                    {
                        lblSearInfo.Text = "No seats booked for this passenger.";
                    }
                }
                else
                {
                    lblSearInfo.Text = $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                lblSearInfo.Text = $"Exception: {ex.Message}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBooking.Visible = true;
            pnlTrain.Visible = false;

        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTrainDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSeatBook_Click(object sender, EventArgs e)
        {
            pnlBooking.Visible = true;
        }

        private void btnBookTrain_Click_1(object sender, EventArgs e)
        {
            pnlBooking.Visible = false;
        }

        private void lblAvaliableSeats_Click(object sender, EventArgs e)
        {

        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void pnlSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlBooking.Visible = false;
            pnlTrain.Visible = false;
            pnlSummary.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }


    public class SearchSchedule
    {
        public int ScheduleId { get; set; }
        public int TrainId { get; set; }
        public string TrainDate { get; set; } 
        public string StartStation { get; set; } 
        public string EndStation { get; set; } 
        public string StartTime { get; set; } 
        public string ArrivalTime { get; set; } 
    }

    public class Train
    {
        public int TrainId { get; set; }
        public string TrainNo { get; set; } = "Not Given";
        public string TrainName { get; set; } = "Not Given";
        public string TrainType { get; set; } = "Not Given";

    }
    public class Booking 
    {

        public int TrainId { get; set; }
        public int ScheduleId { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int SeatNo { get; set; }
        public string PassengerNIC { get; set; } = "Not Given";
    }

    public class Seat
    {
        public int SeatNo { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int TrainId { get; set; }
        public string SeatStatus { get; set; } = "Available";
    }

}
