using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            init_box();
            this.Show();
            
        }
        private void init_box()
        {
            comboBox1.Items.Add("00:00");
            comboBox1.Items.Add("01:00");
            comboBox1.Items.Add("02:00");
            comboBox1.Items.Add("03:00");
            comboBox1.Items.Add("04:00");
            comboBox1.Items.Add("05:00");
            comboBox1.Items.Add("06:00");
            comboBox1.Items.Add("07:00");
            comboBox1.Items.Add("08:00");
            comboBox1.Items.Add("09:00");
            comboBox1.Items.Add("10:00");
            comboBox1.Items.Add("11:00");
            comboBox1.Items.Add("12:00");
            comboBox1.Items.Add("13:00");
            comboBox1.Items.Add("14:00");
            comboBox1.Items.Add("15:00");
            comboBox1.Items.Add("16:00");
            comboBox1.Items.Add("17:00");
            comboBox1.Items.Add("18:00");
            comboBox1.Items.Add("19:00");
            comboBox1.Items.Add("20:00");
            comboBox1.Items.Add("21:00");
            comboBox1.Items.Add("22:00");
            comboBox1.Items.Add("23:00");
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        private void continue__Click(object sender, EventArgs e)
        {
            Parking p = new Parking(dateTimePicker1.Value.ToShortDateString(), comboBox1.SelectedIndex);
            p.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToUniversalTime() < DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Today;
            }
        }
    }
}
