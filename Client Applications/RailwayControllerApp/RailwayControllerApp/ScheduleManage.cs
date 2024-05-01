using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RailwayControllerApp
{

    public partial class ScheduleManage : Form
    {
        private List<Train> trains;
        private List<Schedule> schedules;
        public ScheduleManage()
        {
            InitializeComponent();
            panel1.Visible = false;
            btnUpdate.Enabled = false;
            PopulateComboBox();
            loadSchedule();
            PrintDataGridViewColumns();
        }

        private void ScheduleManage_Load(object sender, EventArgs e)
        {

        }

        private async Task<List<Train>> GetTrains()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:44387/api/Train");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Train>>(json);
                }
                else
                {
                    return new List<Train>();
                }
            }
        }
        public void loadSchedule()
        {
            string url = "https://localhost:44387/api/Schedule";

            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);

            schedules = (new JavaScriptSerializer()).Deserialize<List<Schedule>>(json);
            foreach (var schedule in schedules)
            {
                var train = GetTrainById(schedule.TrainId);
                if (train != null)
                {
                    schedule.TrainName = train.TrainName;
                    schedule.TrainNo = train.TrainNo;
                }
            }

            dgvSchedule.DataSource = null;
            dgvSchedule.DataSource = schedules;
            dgvSchedule.Columns["TrainId"].Visible = false;
            dgvSchedule.Columns["ScheduleId"].Visible = false;
        }
        private async Task PopulateComboBox()
        {
            trains = await GetTrains();
            if (trains.Count > 0)
            {
                cbTrainNo.Items.Clear();
                foreach (var train in trains)
                {
                    cbTrainNo.Items.Add(train.TrainNo);
                    lblID.Text = train.TrainId.ToString();
                }
            }
            else
            {
                cbTrainNo.Items.Add("No trains found");
            }
        }

        private void cbTrainNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrainNo.SelectedItem != null)
            {
                string selectedTrainNo = cbTrainNo.SelectedItem.ToString();
                Train selectedTrain = trains.FirstOrDefault(train => train.TrainNo == selectedTrainNo);
                if (selectedTrain != null)
                {
                    label11.Text = selectedTrain.TrainName;
                    lblID.Text = selectedTrain.TrainId.ToString();
                    panel1.Visible = true;

                }
                else
                {
                    label11.Text = "Train name not found";
                    lblID.Text = "";
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int trainId = Convert.ToInt32(lblID.Text);
            DateTime selectedDate = dtpDate.Value;
            string trainDate = selectedDate.ToString("MM-dd-yyyy");
            string startStation = txtStartStation.Text;
            string endStation = txtEndStation.Text;
            string startTime = txtStartTime.Text;
            string endTime = txtEndTime.Text;

            string url = "https://localhost:44387/api/Schedule";
            HttpClient httpClient = new HttpClient();
            Schedule schedule = new Schedule();
            schedule.TrainId = trainId;
            schedule.TrainDate = trainDate;
            schedule.StartStation = startStation;
            schedule.EndStation = endStation;
            schedule.StartTime = startTime;
            schedule.ArrivalTime = endTime;

            var data = (new JavaScriptSerializer()).Serialize(schedule);
            var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var res = await httpClient.PostAsync(url, content);
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Schedule Added Successfully");
            }
            else
            {
                MessageBox.Show("Schedule Failed to Add");
            }
            loadSchedule();

            txtEndStation.Clear();
            txtEndTime.Clear();
            txtStartTime.Clear();
            txtStartStation.Clear();

        }
        private Train GetTrainById(int trainId)
        {
            string trainUrl = $"https://localhost:44387/api/Train/{trainId}?id={trainId}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(trainUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Train>(json);
                }
                else
                {
                    return null;
                }
            }
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int trainId = Convert.ToInt32(lblID.Text);
            int scheduleId = Convert.ToInt32(lblScheduleID.Text);
            DateTime selectedDate = dtpDate.Value;
            string trainDate = selectedDate.ToString("MM-dd-yyyy");
            string startStation = txtStartStation.Text;
            string endStation = txtEndStation.Text;
            string startTime = txtStartTime.Text;
            string endTime = txtEndTime.Text;

            string url = $"https://localhost:44387/api/Schedule/{scheduleId}?id={scheduleId}";
            var data = new
            {
                trainId = trainId,
                trainDate = trainDate,
                startStation = startStation,
                endStation = endStation,
                startTime = startTime,
                arrivalTime = endTime
            };
            string jsonData = JsonConvert.SerializeObject(data);
            HttpClient client = new HttpClient();
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Schedule updated successfully!");
                txtEndStation.Clear();
                txtEndTime.Clear();
                txtStartTime.Clear();
                txtStartStation.Clear();
                cbTrainNo.Enabled = true;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Schedule updating failed");
            }
            loadSchedule();
        }

        private async void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                lblScheduleID.Text = dgvSchedule.Rows[e.RowIndex].Cells["ScheduleId"].Value.ToString();
                lblID.Text = dgvSchedule.Rows[e.RowIndex].Cells["TrainId"].Value.ToString();
                cbTrainNo.Text = dgvSchedule.Rows[e.RowIndex].Cells["TrainNo"].Value.ToString();
                dtpDate.Text = dgvSchedule.Rows[e.RowIndex].Cells["TrainDate"].Value.ToString();
                txtStartStation.Text = dgvSchedule.Rows[e.RowIndex].Cells["StartStation"].Value.ToString();
                txtEndStation.Text = dgvSchedule.Rows[e.RowIndex].Cells["EndStation"].Value.ToString(); ;
                txtStartTime.Text = dgvSchedule.Rows[e.RowIndex].Cells["StartTime"].Value.ToString();
                txtEndTime.Text = dgvSchedule.Rows[e.RowIndex].Cells["ArrivalTime"].Value.ToString();
                cbTrainNo.Enabled = false;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                

            }
            else if (e.ColumnIndex == 1)
            {
                lblScheduleID.Text = dgvSchedule.Rows[e.RowIndex].Cells["ScheduleId"].Value.ToString();
                int schedule_Id = Convert.ToInt32(lblScheduleID.Text);
                Console.WriteLine(schedule_Id);
                string url = $"https://localhost:44387/api/Schedule/{schedule_Id}?id={schedule_Id}";
                HttpClient client = new HttpClient();
                DialogResult result = MessageBox.
                                Show("Are you sure you want to delete?",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var res = await client.DeleteAsync(url);
                        res.EnsureSuccessStatusCode(); // Ensure the response is successful, otherwise an exception will be thrown
                        MessageBox.Show("Schedule deleted successfully");
                        loadSchedule();
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Failed to delete the schedule. Error: {ex.Message}");
                    }
                }
            }
        }
        private void PrintDataGridViewColumns()
        {
            Console.WriteLine("DataGridView Columns:");
            foreach (DataGridViewColumn column in dgvSchedule.Columns)
            {
                Console.WriteLine($"Column Name: {column.Name}, Index: {column.Index}");
            }
        }

        public class Schedule
    {
        public int ScheduleId { get; set; }
        public int TrainId { get; set; }
        public string TrainDate { get; set; }
        public string StartStation { get; set; }
        public string EndStation { get; set; }
        public string StartTime { get; set; }
        public string ArrivalTime { get; set; }
        public string TrainName { get; set; }
        public string TrainNo { get; set; }

    }


}
    }
