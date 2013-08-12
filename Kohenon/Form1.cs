using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kohenon
{
    public partial class Form1 : Form
    {
        double[,] weights = new double[4,2];
        List<input> list = new List<input>();
        int epoch;
        double alpha;

        input item;
        int window = 0;
        public Form1()
        {
            InitializeComponent();
            i0.Left = 127;
            i0.Top = 29;
            i1.Left = 147;
            i1.Top = 29;
            i2.Left = 167;
            i2.Top = 29;
            i3.Left = 187;
            i3.Top = 29;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i0.Focus();
            if (window == 1)
            {
                item = new input();
                item.i[0] = int.Parse(i0.Text);
                item.i[1] = int.Parse(i1.Text);
                item.i[2] = int.Parse(i2.Text);
                item.i[3] = int.Parse(i3.Text);
                list.Add(item);
                label3.Text = "Input " + list.Count.ToString() + " Added";
                i0.Text = "";
                i1.Text = "";
                i2.Text = "";
                i3.Text = "";
            }
            else
            {
                window = 1;
                learningRate.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                label1.Text = "Input Vectors";
                button1.Text = "Add";

                i0.Visible = true;
                i1.Visible = true;
                i2.Visible = true;
                i3.Visible = true;

                w00.ReadOnly = true;
                w01.ReadOnly = true;
                w10.ReadOnly = true;
                w11.ReadOnly = true;
                w20.ReadOnly = true;
                w21.ReadOnly = true;
                w30.ReadOnly = true;
                w31.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            window = 0;
            learningRate.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Text = "Next";
            label1.Text = "Learning Rate";

            i0.Visible = false;
            i1.Visible = false;
            i2.Visible = false;
            i3.Visible = false;

            w00.ReadOnly = false;
            w01.ReadOnly = false;
            w10.ReadOnly = false;
            w11.ReadOnly = false;
            w20.ReadOnly = false;
            w21.ReadOnly = false;
            w30.ReadOnly = false;
            w31.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (epochInput.Text == "")
            {
                i0.Enabled = i1.Enabled = i2.Enabled = i3.Enabled = false;
                w00.Enabled = w01.Enabled = w10.Enabled = w11.Enabled = false;
                w20.Enabled = w21.Enabled = w30.Enabled = w31.Enabled = false;
                label3.Left = 80;
                label3.Text = "Enter The no of Epochs";
                epochInput.Visible = true;
                epochInput.Focus();
                button3.Text = "Compute";
                button1.Enabled = button2.Enabled = false;
                epochInput.Focus();
            }
            else if (epochInput.ReadOnly == false)
            {
                epochInput.ReadOnly = true;
                button3.Text = "Exit";
                extract();
                compute();

                w00.Text = weights[0, 0].ToString();
                w01.Text = weights[0, 1].ToString();
                w10.Text = weights[1, 0].ToString();
                w11.Text = weights[1, 1].ToString();
                w20.Text = weights[2, 0].ToString();
                w21.Text = weights[2, 1].ToString();
                w30.Text = weights[3, 0].ToString();
                w31.Text = weights[3, 1].ToString();

                label1.Text = "Final Weight Matrix";
                label1.Left = 95;
                label3.Text = "Finished";
                label3.Left = 125;
                epochInput.Visible = false;
                i0.Visible = i1.Visible = i2.Visible = i3.Visible = false;

                string message = "";
                for (int j = 0; j < list.Count; j++)
                {
                    message += "Input " + (j + 1) + " Belongs to Cluster " + list[j].cluster + "\n\r";
                }

                MessageBox.Show(message, "Finished!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                Application.Exit();
        }

        private void extract()
        {
            weights[0, 0] = double.Parse(w00.Text);
            weights[0, 1] = double.Parse(w01.Text);
            weights[1, 0] = double.Parse(w10.Text);
            weights[1, 1] = double.Parse(w11.Text);
            weights[2, 0] = double.Parse(w20.Text);
            weights[2, 1] = double.Parse(w21.Text);
            weights[3, 0] = double.Parse(w30.Text);
            weights[3, 1] = double.Parse(w31.Text);
            epoch = int.Parse(epochInput.Text);
            alpha = double.Parse(learningRate.Text);
        }

        private void compute()
        {
            double d1,d2;
            while (epoch != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    d1 =  Math.Pow((list[i].i[0] - weights[0, 0]), 2) + Math.Pow((list[i].i[1] - weights[1, 0]), 2);
                    d1 += Math.Pow((list[i].i[2] - weights[2, 0]), 2) + Math.Pow((list[i].i[3] - weights[3, 0]), 2);

                    d2 =  Math.Pow((list[i].i[0] - weights[0, 1]), 2) + Math.Pow((list[i].i[1] - weights[1, 1]), 2);
                    d2 += Math.Pow((list[i].i[2] - weights[2, 1]), 2) + Math.Pow((list[i].i[3] - weights[3, 1]), 2);

                    if (d1 < d2 || d1.Equals(d2))
                    {
                        weights[0, 0] = weights[0, 0] + alpha * (list[i].i[0] - weights[0, 0]);
                        weights[1, 0] = weights[1, 0] + alpha * (list[i].i[1] - weights[1, 0]);
                        weights[2, 0] = weights[2, 0] + alpha * (list[i].i[2] - weights[2, 0]);
                        weights[3, 0] = weights[3, 0] + alpha * (list[i].i[3] - weights[3, 0]);
                        list[i].cluster = 1;
                    }
                    else
                    {
                        weights[0, 1] = weights[0, 1] + alpha * (list[i].i[0] - weights[0, 1]);
                        weights[1, 1] = weights[1, 1] + alpha * (list[i].i[1] - weights[1, 1]);
                        weights[2, 1] = weights[2, 1] + alpha * (list[i].i[2] - weights[2, 1]);
                        weights[3, 1] = weights[3, 1] + alpha * (list[i].i[3] - weights[3, 1]);
                        list[i].cluster = 2;
                    }
                }
                epoch--;
            }
        }
    }

    class input
    {
        public int[] i;
        public int cluster;
        public input()
        {
            i = new int[4];
        }
    }
}
