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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            customerPanel.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = false;
            dataGridPanel.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridPanel.Visible = false;
            customerPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = false;
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tourguide_p.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tourguide_gride.Visible = true;
            tourguide_p.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Show();
            tourguide_p.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tourguide_p.Visible = true;
            tourguide_gride.Visible = false;
        }

        private void tourguide_gride_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
