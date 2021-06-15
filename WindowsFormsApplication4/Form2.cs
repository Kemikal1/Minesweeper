using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        int s = 0;
        int []v = new int[20];

        public Form2()
        {
           
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox11.Text = s.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
             axWindowsMediaPlayer1.Ctlcontrols.play();
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(v[0]==0)
            {
                textBox1.BackColor = Color.Red;
                v[0] = 1;
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Red;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (v[0] == 0)
            {
                s++;
                textBox1.BackColor = Color.Green;
                v[0] = 1;
                button3.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (v[0] == 0)
            {
                textBox1.BackColor = Color.Red;
                v[0] = 1;
                button3.BackColor = Color.Green;
                button2.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (v[1] == 0)
            {
                s++;
                textBox2.BackColor = Color.Green;
                v[1] = 1;
                button4.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (v[1] == 0)
            {
                
                textBox2.BackColor = Color.Red;
                v[1] = 1;
                button6.BackColor = Color.Red;
                button4.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (v[1] == 0)
            {
                
                textBox2.BackColor = Color.Red;
                v[1] = 1;
                button5.BackColor = Color.Red;
                button4.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (v[2] == 0)
            {
                s++;
                textBox3.BackColor = Color.Green;
                v[2] = 1;
                button9.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (v[2] == 0)
            {
                
                textBox3.BackColor = Color.Red;
                v[2] = 1;
                button9.BackColor = Color.Green;
                button8.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (v[2] == 0)
            {

                textBox3.BackColor = Color.Red;
                v[2] = 1;
                button9.BackColor = Color.Green;
                button8.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (v[3] == 0)
            {

                textBox6.BackColor = Color.Red;
                v[3] = 1;
                button12.BackColor = Color.Green;
                button11.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (v[3] == 0)
            {
                s++;
                textBox6.BackColor = Color.Green;
                v[3] = 1;
                button12.BackColor = Color.Green;
               
                textBox11.Text = s.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (v[3] == 0)
            {

                textBox6.BackColor = Color.Red;
                v[3] = 1;
                button12.BackColor = Color.Green;
                button10.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (v[4] == 0)
            {
                s++;
                textBox5.BackColor = Color.Green;
                v[4] = 1;
                button14.BackColor = Color.Green;

                textBox11.Text = s.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (v[4] == 0)
            {
                
                textBox5.BackColor = Color.Red;
                v[4] = 1;
                button15.BackColor = Color.Red;
                button14.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (v[4] == 0)
            {
                textBox5.BackColor = Color.Red;
                v[4] = 1;
                button13.BackColor = Color.Red;
                button14.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (v[5] == 0)
            {
                s++;
                textBox4.BackColor = Color.Green;
                v[5] = 1;
                button16.BackColor = Color.Green;

                textBox11.Text = s.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (v[5] == 0)
            {
                
                textBox4.BackColor = Color.Red;
                v[5] = 1;
                button16.BackColor = Color.Green;
                button17.BackColor = Color.Red;

                textBox11.Text = s.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (v[5] == 0)
            {

                textBox4.BackColor = Color.Red;
                v[5] = 1;
                button16.BackColor = Color.Green;
                button18.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if(v[6]==0)
            {
                v[6] = 1;
                if(textBox12.Text== "Raspunsul:aurum" || textBox12.Text== "Raspunsul:Aurum"|| textBox12.Text == "Aurum" || textBox12.Text == "aurum")
                {
                    textBox9.BackColor = Color.Green;
                    textBox12.ReadOnly = true;
                    textBox9.BackColor = Color.Green;
                    s++; textBox11.Text = s.ToString();
                }
                else
                {
                    textBox12.BackColor = Color.Red;
                    textBox9.BackColor = Color.Red;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (v[7] == 0)
            {
                s++;
                textBox8.BackColor = Color.Green;
                v[7] = 1;
                button21.BackColor = Color.Green;

                textBox11.Text = s.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (v[7] == 0)
            {
                
                textBox8.BackColor = Color.Red;
                v[7] = 1;
                button21.BackColor = Color.Green;
                button20.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (v[7] == 0)
            {

                textBox8.BackColor = Color.Red;
                v[7] = 1;
                button21.BackColor = Color.Green;
                button19.BackColor = Color.Red;
                textBox11.Text = s.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (v[8] == 0)
            {
                s++;
                textBox7.BackColor = Color.Green;
                v[8] = 1;
                button23.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (v[8] == 0)
            {
                
                textBox7.BackColor = Color.Red;
                v[8] = 1;
                button22.BackColor = Color.Red;
                button23.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (v[8] == 0)
            {

                textBox7.BackColor = Color.Red;
                v[8] = 1;
                button24.BackColor = Color.Red;
                button23.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (v[9] == 0)
            {
                s++;
                textBox10.BackColor = Color.Green;
                v[9] = 1;
                button26.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (v[9] == 0)
            {
                s++;
                textBox10.BackColor = Color.Red;
                v[9] = 1;
                button27.BackColor = Color.Red;
                button26.BackColor = Color.Green;
                textBox11.Text = s.ToString();
            }
        }
    }
}
