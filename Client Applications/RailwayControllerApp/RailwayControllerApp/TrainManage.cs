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
using System.Security.Policy;

namespace RailwayControllerApp
{
    public partial class TrainManage : Form
    {
        int id;
        string class1 = "First Class";
        string class2 = "Second Class";
        string class3 = "Third Class";
        public TrainManage()
        {
            InitializeComponent();
        }
        

        private void Train_Load(object sender, EventArgs e)
        {
            loadTrains();
            btnUpdate.Enabled = false;
        }

        private async void dgvTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string formattedClass1 = Uri.EscapeDataString(class1);
            string formattedClass2 = Uri.EscapeDataString(class2);
            string formattedClass3 = Uri.EscapeDataString(class3);
            if (e.ColumnIndex == 0)
            {
                lblID.Text = dgvTrains.
                    Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNo.Text = dgvTrains.
                   Rows[e.RowIndex].Cells[3].Value.ToString();
                txtName.Text = dgvTrains.
                   Rows[e.RowIndex].Cells[4].Value.ToString();
                txtType.Text = dgvTrains.
                   Rows[e.RowIndex].Cells[5].Value.ToString();

                id = Convert.ToInt32(dgvTrains.
                    Rows[e.RowIndex].Cells[2].Value.ToString());
                lblID.Text = id.ToString();

                

                string urlClass1 = $"https://localhost:44387/api/Class/TotalSeats?trainId={id}&className={formattedClass1}";
                string urlClass2 = $"https://localhost:44387/api/Class/TotalSeats?trainId={id}&className={formattedClass2}";
                string urlClass3 = $"https://localhost:44387/api/Class/TotalSeats?trainId={id}&className={formattedClass3}";

                HttpClient client = new HttpClient();

                HttpResponseMessage response1 = await client.GetAsync(urlClass1);
                HttpResponseMessage response2 = await client.GetAsync(urlClass2);
                HttpResponseMessage response3 = await client.GetAsync(urlClass3);

                if (response1.IsSuccessStatusCode && response2.IsSuccessStatusCode && response3.IsSuccessStatusCode)
                {

                    string content1 = await response1.Content.ReadAsStringAsync();
                    string content2 = await response2.Content.ReadAsStringAsync();
                    string content3 = await response3.Content.ReadAsStringAsync();

                    int class1Seats = int.Parse(content1);
                    int class2Seats = int.Parse(content2);
                    int class3Seats = int.Parse(content3);

                    txtClass1.Text = class1Seats.ToString();
                    txtClass2.Text = class2Seats.ToString();
                    txtClass3.Text = class3Seats.ToString();
                    btnUpdate.Enabled = true;
                    btnAdd.Enabled = false;

                }
            }
            else if (e.ColumnIndex == 1)
            {
                id = Convert.ToInt32(dgvTrains.
                    Rows[e.RowIndex].Cells[2].Value.ToString());
                string url = $"https://localhost:44387/api/Train/{id}?id={id}";

                string urlClass1 = $"https://localhost:44387/api/Class/RemoveClass/{id}/{formattedClass1}";
                string urlClass2 = $"https://localhost:44387/api/Class/RemoveClass/{id}/{formattedClass2}";
                string urlClass3 = $"https://localhost:44387/api/Class/RemoveClass/{id}/{formattedClass3}";

                HttpClient client = new HttpClient();
                DialogResult result = MessageBox.
                                Show("Are you sure you want to delete?",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var res = client.DeleteAsync(url).Result;
                    var res1 = client.DeleteAsync(urlClass1).Result;
                    var res2 = client.DeleteAsync(urlClass2).Result;
                    var res3 = client.DeleteAsync(urlClass3).Result;
                    if (res.IsSuccessStatusCode && res1.IsSuccessStatusCode && res2.IsSuccessStatusCode && res3.IsSuccessStatusCode)
                    {
                        loadTrains();
                        
                    }
                    else { 

                        loadTrains();
                    }
                }

            }
        }
        public void loadTrains()
        {
            string url = "https://localhost:44387/api/Train";
  
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);

            List<Train> trains = (new JavaScriptSerializer()).Deserialize<List<Train>>(json);
            dgvTrains.DataSource = null;
            dgvTrains.DataSource = trains;
            dgvTrains.Columns["TrainId"].Visible = false;
            

        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string Train_No = txtNo.Text;
                string Train_Name = txtName.Text;
                string Train_Type = txtType.Text;
                int classSeats1 = Convert.ToInt32(txtClass1.Text);
                int classSeats2 = Convert.ToInt32(txtClass2.Text);
                int classSeats3 = Convert.ToInt32(txtClass3.Text);

                string trainUrl = "https://localhost:44387/api/Train";
                HttpClient client = new HttpClient();
                Train train = new Train();

                train.TrainNo = Train_No;
                train.TrainName = Train_Name;
                train.TrainType = Train_Type;

                string data = (new JavaScriptSerializer()).Serialize(train);
                var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
                var res = await client.PostAsync(trainUrl, content);
                if (res.IsSuccessStatusCode)
                {

                    string responseData = await res.Content.ReadAsStringAsync();
                    int trainID = int.Parse(responseData);

                    string ClassUrl = "https://localhost:44387/api/Class";
                    HttpClient httpClient = new HttpClient();
                    TrainClass trainClass1 = new TrainClass();
                    TrainClass trainClass2 = new TrainClass();
                    TrainClass trainClass3 = new TrainClass();

                    trainClass1.TrainId = trainID;
                    trainClass1.ClassName = class1;
                    trainClass1.NoOfSeats = classSeats1;
                    trainClass1.AvailableSeats = classSeats1;

                    trainClass2.TrainId = trainID;
                    trainClass2.ClassName = class2;
                    trainClass2.NoOfSeats = classSeats2;
                    trainClass2.AvailableSeats = classSeats2;

                    trainClass3.TrainId = trainID;
                    trainClass3.ClassName = class3;
                    trainClass3.NoOfSeats = classSeats3;
                    trainClass3.AvailableSeats = classSeats3;

                    var classData1 = (new JavaScriptSerializer()).Serialize(trainClass1);
                    var classContent1 = new StringContent(classData1, UnicodeEncoding.UTF8, "application/json");
                    var classRes1 = await httpClient.PostAsync(ClassUrl, classContent1);

                    var classData2 = (new JavaScriptSerializer()).Serialize(trainClass2);
                    var classContent2 = new StringContent(classData2, UnicodeEncoding.UTF8, "application/json");
                    var classRes2 = await httpClient.PostAsync(ClassUrl, classContent2);

                    var classData3 = (new JavaScriptSerializer()).Serialize(trainClass3);
                    var classContent3 = new StringContent(classData3, UnicodeEncoding.UTF8, "application/json");
                    var classRes3 = await httpClient.PostAsync(ClassUrl, classContent3);

                    if (classRes1.IsSuccessStatusCode && classRes2.IsSuccessStatusCode && classRes3.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Train and Classes Added Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Failed to add classes");
                    }
                }
                else
                {
                    MessageBox.Show("Train Adding Failed");

                }
                loadTrains();
                txtName.Clear();
                txtNo.Clear();
                txtType.Clear();
                txtClass1.Clear();
                txtClass2.Clear();
                txtClass3.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Values in Correct Form");
            }
            

        }

        private void txtClass2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int TrainID = Convert.ToInt32(lblID.Text);
            string Train_No = txtNo.Text;
            string Train_Name = txtName.Text;
            string Train_Type = txtType.Text;
            int classSeats1 = Convert.ToInt32(txtClass1.Text);
            int classSeats2 = Convert.ToInt32(txtClass2.Text);
            int classSeats3 = Convert.ToInt32(txtClass3.Text);

            string url = $"https://localhost:44387/api/Train/UpdateTrain/{TrainID}?id={TrainID}";

            var updatedTrainData = new
            {
                trainNo = Train_No,
                trainName = Train_Name,
                trainType = Train_Type
            };

            string jsonData = JsonConvert.SerializeObject(updatedTrainData);
            HttpClient client = new HttpClient();
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                string formattedClass1 = Uri.EscapeDataString(class1);
                string formattedClass2 = Uri.EscapeDataString(class2);
                string formattedClass3 = Uri.EscapeDataString(class3);

                //Class Updating
                string updateUrl1 = $"https://localhost:44387/api/Class/UpdateClass/{TrainID}/{formattedClass1}";
                string updateUrl2 = $"https://localhost:44387/api/Class/UpdateClass/{TrainID}/{formattedClass2}";
                string updateUrl3 = $"https://localhost:44387/api/Class/UpdateClass/{TrainID}/{formattedClass3}";
                Console.WriteLine(updateUrl1);
                Console.WriteLine(updateUrl2);
                    Console.WriteLine(updateUrl3);
                var updatedClassData1 = new
                {
                    className = class1,
                    trainId = TrainID,
                    noOfSeats = classSeats1,
                    availableSeats = classSeats1
                };

                var updatedClassData2 = new
                {
                    className = class2,
                    trainId = TrainID,
                    noOfSeats = classSeats2,
                    availableSeats = classSeats2
                };

                var updatedClassData3 = new
                {
                    className = class3,
                    trainId = TrainID,
                    noOfSeats = classSeats3,
                    availableSeats = classSeats3
                };
               
                string jsonData1 = JsonConvert.SerializeObject(updatedClassData1);
                string jsonData2 = JsonConvert.SerializeObject(updatedClassData2);
                string jsonData3 = JsonConvert.SerializeObject(updatedClassData3);
                Console.WriteLine(jsonData1);
                Console.WriteLine(jsonData2);
                Console.WriteLine(jsonData3);
                var content1 = new StringContent(jsonData1, Encoding.UTF8, "application/json");
                var content2 = new StringContent(jsonData2, Encoding.UTF8, "application/json");
                var content3 = new StringContent(jsonData3, Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = await client.PutAsync(updateUrl1, content1);
                HttpResponseMessage response2 = await client.PutAsync(updateUrl2, content2);
                HttpResponseMessage response3 = await client.PutAsync(updateUrl3, content3);

                MessageBox.Show("Train updated successfully!");
                txtName.Clear();
                txtNo.Clear();
                txtType.Clear();
                txtClass1.Clear();
                txtClass2.Clear();
                txtClass3.Clear();
                btnAdd.Enabled = true;
                

            }
            else
            {
                MessageBox.Show("Failed to update train. Please try again.");
            }
            loadTrains();
           
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

        public class TrainClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; } = "Not Given";
        public int TrainId { get; set; }
        public int NoOfSeats { get; set; }
        public int AvailableSeats { get; set; }

    }


}
