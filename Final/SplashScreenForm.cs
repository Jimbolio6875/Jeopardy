using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class SplashScreenForm : Form
    {

        //Form1 form1 = new Form1();
        //SplashScreenForm splashForm = new SplashScreenForm();
        Options options = new Options();
        private int count = 0;

        public SplashScreenForm()
        {
            InitializeComponent();
            
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenForm splashScreenForm = new SplashScreenForm();
            splashScreenForm.BringToFront();

            textBox1.Enabled = false;
            textBox2.Enabled = false;

            textBox1.BringToFront();

            button1.Hide();
        }

        // timer tick event that calls progress bar method each time it ticks
        // also when the count reaches a certain number the continue button shows up
        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar();
            count++;
            
            if (count == 450)
            {
                button1.Show();
            }
        }

        // makes a loading bar out of two textboxes
        // called by timertick event function
        private void ProgressBar()
        {
            textBox1.Left += 2;
            textBox1.Width = 100;

            if (textBox1.Left > 345)
            {
                textBox1.Left = 175;
            }
        }

        // hides the splashscreen and shows the dialogue box
        private void button1_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            this.Hide();
            options.ShowDialog();
        }
    }
}
