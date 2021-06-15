using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            button9.Visible = false;


        }
        Form g;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
       // StreamReader f = new StreamReader(@"C:\elev\12a\WindowsFormsApplication4\WindowsFormsApplication4\TextFile1.txt");
        Button [,] v = new Button[100,100];
        int col = 20, lin = 50,s2=1,s3;
        int n ,s=0,s1=0,q=0;
        int[,] a = new int[100, 100];
        int i1, j1;
        char []cuv=new char[400];
        void back(int k,int i,int j,int d)
        {
            int x,y,ii,jj;
            int[] z = new int[100];
            z[0] = -1;
            z[1] = 0;
            z[2] = 1;
            
            if (a[i, j] != 0) k++;
            if (a[i, j] != -2 && k < 1)

            {

                if (a[i, j] != -1)
                {
                   if(a[i,j]!=0)
                    v[i, j].Text = a[i, j].ToString();
                    a[i, j] = -2;
                    v[i, j].BackColor = Color.LightBlue;
                    for (x = 0; x < 3; x++)
                        for (y = 0; y < 3; y++)
                        {

                            ii = i + z[x];
                            jj = j + z[y];

                            if (ii > -1 && jj > -1 && ii < n && jj < n)
                            {

                                if (a[ii, jj] != -2)
                                    if (a[ii, jj] != -1)

                                    {


                                        v[ii, jj].BackColor = Color.LightBlue;
                                        if(a[ii,jj]!=0)
                                         v[ii, jj].Text = a[ii, jj].ToString();
                                        back(k, ii, jj, d++);
                                        a[ii, jj] = -2;

                                    }

                            }
                        }
                }
            }
            //else
               /* if (d == 0 && a[i,j]!=-1&&a[i,j]!=-2)
            { v[i, j].BackColor = Color.Purple;
                v[i, j].Text = a[i, j].ToString();
                a[i, j] = -2; }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s3 = 0;
            button9.Visible = false;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = 0;
                    v[i, j].Visible = true;
                    v[i, j].Text = null;
                    v[i, j].BackColor = Color.LightGray;
                    v[i, j].BackgroundImage = null;
                }

                    Random r = new Random();
                    int l, k;
                    int[] z = new int[100];
                    z[0] = -1;
                    z[1] = 0;
                    z[2] = 1;
            label1.Visible = false;
            label2.Visible = false;
            s1 = 0;
            s2 = 0;
            for (int h = 0; h < (3 * n - 2 * n % 10) / 3 * 2-1; h++)
                    {
                        l = r.Next(0, n);
                        k = r.Next(0, n);
                        if (a[l, k] != -1)
                        {
                            a[l, k] = -1;
                            for (int i = 0; i < 3; i++)
                                for (int j = 0; j < 3; j++)
                                {
                                    if ((z[i] + l) < n && (z[i] + l) > -1 && (z[j] + k) > -1 && (z[j] + k) < n && a[l + z[i], k + z[j]] != -1)
                                    {
                                        a[l + z[i], k + z[j]]++;
                                        //  v[z[i] + l, z[j] + k].Text = a[z[i] + l, z[j] + k].ToString();
                                     }

                                }
                            a[l, k] = -1;
                            // v[l, k].Text = "-1";
                        }
                        else
                            h--;
                    }

                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (q == 0)
            { q = 1; button4.BackColor = Color.LightBlue; }
            else
            { q = 0; button4.BackColor = Color.White; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ceva(object sender, EventArgs e)
        {
            int i2 = i1, j2 = i1;
            i2 = int.Parse(((Button)sender).Name) / 100;
            j2 = int.Parse(((Button)sender).Name) % 100;
            Console.WriteLine(j2);
            Console.WriteLine(i2);
            if (q == 0)
            {
                if (a[i2, j2] != -1 && s1 == 0 && a[i2, j2]<10 && a[i2, j2]>-10)
                {
                    if (a[i2, j2] != -1 && a[i2, j2] != -2 && a[i2, j2] != 0)
                    {
                        v[i2, j2].BackColor = Color.LightBlue;
                        v[i2, j2].Text = a[i2, j2].ToString();
                    }
                    back(0, i2, j2, 0);
                }
                if (a[i2, j2] == -1)
                {
                    s1 = 1;
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            if (a[i, j] == -1||a[i,j]==-10||a[i,j]>10||a[i,j]<-9)
                            {
                                v[i, j].BackgroundImage = Image.FromFile(Application.StartupPath + "\\images.jpg");
                                label1.Visible = true;
                                v[i, j].BackgroundImageLayout = ImageLayout.Stretch;


                            }
                    button9.Visible = true;

                }
                int oi = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (a[i, j] < -9)
                            oi++;
                if(oi== (3 * n - 2 * n % 10) / 2*3-1)
                {
                    s2 = 1;
                    label2.Visible = true;
                }

            }
            else
            {
                if (a[i2, j2] != -2)
                {
                    if (a[i2, j2] < 10 && a[i2, j2] > -10 )
                    {
                        if(a[i2, j2]>0)
                        a[i2, j2] ++;
                        else
                            a[i2, j2]--;
                        a[i2, j2] *= 10;
                        v[i2, j2].BackgroundImage = Image.FromFile(Application.StartupPath + "\\image.jpg");
                        v[i2, j2].BackgroundImageLayout = ImageLayout.Stretch;
                        //  button4.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        v[i2, j2].BackgroundImage = null;
                       
                        a[i2, j2] /= 10;
                        if (a[i2, j2] > 0)
                            a[i2, j2]--;
                        if (a[i2, j2] < 0)
                            a[i2, j2]++;
                        // button4.BackColor = Color.White;
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)

        {
            
            if (s == 0)
            {
                button3.Visible = true;
                button9.Visible = false;
                label1.Visible = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        v[i, j] = new Button();
                        v[i, j].Parent = this;
                        v[i, j].Bounds = new Rectangle(col, lin, 40, 40);

                        if (i < 10)
                            v[i, j].Name = '0' + i.ToString();
                        else
                            v[i, j].Name = i.ToString();

                        if (j < 10)
                            v[i, j].Name = v[i, j].Name + "0" + j.ToString();
                        else
                            v[i, j].Name = v[i, j].Name + j.ToString();

                        v[i, j].BackColor = Color.LightGray;
                        col += 38;
                        i1 = i;
                        j1 = j;
                        v[i, j].Click += new EventHandler(ceva);
                    }
                    col = 20;
                    lin += 38;
                }
                s = 1;

                Random r = new Random();
                int l, k;
                int[] z = new int[100];
                z[0] = -1;
                z[1] = 0;
                z[2] = 1;

                for (int h = 0; h < (3 * n - 2 * n % 10) / 3 * 2-1; h++)
                {
                    l = r.Next(0, n - 1);
                    k = r.Next(0, n - 1);
                    if (a[l, k] != -1)
                    {
                        a[l, k] = -1;
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 3; j++)
                            {
                                if ((z[i] + l) < n && (z[i] + l) > -1 && (z[j] + k) > -1 && (z[j] + k) < n && a[l + z[i], k + z[j]] != -1)
                                {
                                    a[l + z[i], k + z[j]]++;
                                    //  v[z[i] + l, z[j] + k].Text = a[z[i] + l, z[j] + k].ToString();
                                }

                            }
                        a[l, k] = -1;
                        // v[l, k].Text = "-1";
                    }
                    else
                        h--;
                }
                s = 1;

            }


            
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //g = new Form2();
            //g.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
                 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog cs = new OpenFileDialog();
            cs.ShowDialog();
            axWindowsMediaPlayer1.URL = cs.FileName;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            n = 6;
            textBox2.Visible = false;
            button1.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            n = 13;
            textBox2.Visible = false;
            button1.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            n = 17;
            textBox2.Visible = false;
            button1.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label1.Visible = false;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = 0;
                    v[i, j].Visible = false;
                   
                }
            textBox2.Visible = true;
            button1.Visible = false;
            button4.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            s3 = 1;
        }

        

         
    }
}
