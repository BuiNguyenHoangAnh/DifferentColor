using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int temp, diem = 0;

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult rp = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rp == DialogResult.Yes)
                Application.Exit();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            temp = r.Next(1, 9);
            switch(temp)
            {
                case 1:
                    {
                        this.pictureBox1.BackColor = SystemColors.Highlight;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 2:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.Highlight;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 3:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.Highlight;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 4:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.Highlight;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 5:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.Highlight;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 6:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.Highlight;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 7:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.Highlight;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 8:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.Highlight;
                        this.pictureBox9.BackColor = SystemColors.HotTrack;
                        break;
                    }
                case 9:
                    {
                        this.pictureBox1.BackColor = SystemColors.HotTrack;
                        this.pictureBox2.BackColor = SystemColors.HotTrack;
                        this.pictureBox3.BackColor = SystemColors.HotTrack;
                        this.pictureBox4.BackColor = SystemColors.HotTrack;
                        this.pictureBox5.BackColor = SystemColors.HotTrack;
                        this.pictureBox6.BackColor = SystemColors.HotTrack;
                        this.pictureBox7.BackColor = SystemColors.HotTrack;
                        this.pictureBox8.BackColor = SystemColors.HotTrack;
                        this.pictureBox9.BackColor = SystemColors.Highlight;
                        break;
                    }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (temp == 1)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (temp == 2)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (temp == 3)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (temp == 4)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (temp == 5)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (temp == 6)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (temp == 7)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (temp == 8)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (temp == 9)
            {
                diem = diem + 10;
                bt_start_Click(sender, e);
                this.label2.Text = Convert.ToString(diem);
            }
        }
    }
}
