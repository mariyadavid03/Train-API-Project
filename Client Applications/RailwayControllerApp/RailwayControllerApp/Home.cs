using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayControllerApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addSchduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleManage form2 = new ScheduleManage();
            form2.MdiParent = this;
            form2.FormClosed += ChildFormClosed;
            panel1.Visible = false;
            form2.Show();
            
        }
        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
   
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void addTrainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainManage form1 = new TrainManage();
            form1.FormClosed += ChildFormClosed;
            form1.MdiParent = this;
            panel1.Visible = false;
            form1.Show();
        }

        private void btnTrainManage_Click(object sender, EventArgs e)
        {
            TrainManage form1 = new TrainManage();
            form1.FormClosed += ChildFormClosed;
            form1.MdiParent = this;
            panel1.Visible = false;
            form1.Show();
        }

        private void btnScheduleManage_Click(object sender, EventArgs e)
        {
            ScheduleManage form2 = new ScheduleManage();
            form2.FormClosed += ChildFormClosed;
            form2.MdiParent = this;
            panel1.Visible = false;
            form2.Show();
        }
    }
}
