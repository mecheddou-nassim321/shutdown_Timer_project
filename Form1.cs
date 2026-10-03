using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shutdown_Timer_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
           
            btn_minute.Text = Convert.ToString(numericUpDown1.Value);


            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)numericUpDown1.Value;
            progressBar1.Visible = true;
            for (int i = 0; i <= numericUpDown1.Value; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value++;
                    // progressBar1.Minimum++;

                    label8.Text = Math.Floor((((float)progressBar1.Value / progressBar1.Maximum)*100 )) + "%";


                    int btnMinuteValue = Convert.ToInt32(btn_minute.Text);
                    int remaining = btnMinuteValue - progressBar1.Value;
                    Remaining_Time.Text = $"00:{remaining:00}:00";
                    Application.DoEvents();

                }
            }
        }
        

        private void progressBar1_Click(object sender, EventArgs e)
        {
           


        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 0;
            progressBar1.Visible = true;
            numericUpDown1.Value = 0;
            label8.Text = 0 + "%";
            btn_minute.Text = Convert.ToString(numericUpDown1.Value);
           
            MessageBox.Show("Stop");
        }
    }
}
