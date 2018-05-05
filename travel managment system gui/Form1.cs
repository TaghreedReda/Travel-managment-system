using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travel_managment_system_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_B_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this);
            admin.Show();
            this.Hide();
            
        }
     

       

        private void LandingManagerButton_Click(object sender, EventArgs e)
        {
            ManagerPanel.Visible = true;
            ManagerCreatePanel.Visible = false;
        }

        private void LandingExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminCreateButton_Click(object sender, EventArgs e)
        {
            ManagerCreatePanel.Visible = true;
            ManagerPanel.Visible = false;
        }

        private void AdminBackButton_Click(object sender, EventArgs e)
        {
            ManagerPanel.Visible = false;
        }

        private void CreationBackButton_Click(object sender, EventArgs e)
        {
            ManagerPanel.Visible = true;
            ManagerCreatePanel.Visible = false;
        }

        private void ManagerCreatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
