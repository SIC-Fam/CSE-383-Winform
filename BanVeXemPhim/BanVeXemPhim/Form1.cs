using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXemPhim
{
    public partial class Form1 : Form
    {
        int tong = 0;
        public void btnclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Green)
            {
                if (button.Text.Contains("A"))
                {
                    button.BackColor = Color.LightBlue;
                    tong -= 25000;
                } else if (button.Text.Contains("B"))
                {
                    button.BackColor = Color.LightGreen;
                    tong -= 30000;
                }
                else if (button.Text.Contains("C"))
                {
                    button.BackColor = Color.Yellow;
                    tong -= 35000;
                }
                else if (button.Text.Contains("D"))
                {
                    button.BackColor = Color.LightPink;
                    tong -= 40000;
                }
                else if (button.Text.Contains("E"))
                {
                    button.BackColor = Color.OrangeRed;
                    tong -= 45000;
                }
                else if (button.Text.Contains("F"))
                {
                    button.BackColor = Color.Orange;
                    tong -= 50000;
                } 
            } else
            {
                button.BackColor = Color.Green;
                if (button.Text.Contains("A"))
                {
                    tong += 25000;
                }
                else if (button.Text.Contains("B"))
                {
                    tong += 30000;
                }
                else if (button.Text.Contains("C"))
                {
                    tong += 35000;
                }
                else if (button.Text.Contains("D"))
                {
                    tong += 40000;
                }
                else if (button.Text.Contains("E"))
                {
                    tong += 45000;
                }
                else if (button.Text.Contains("F"))
                {
                    tong += 50000;
                }
            }
            label5.Text = tong.ToString();
        }

        public void re()
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++) {
                    Control x = tableLayoutPanel1.GetControlFromPosition(i, j);
                    tableLayoutPanel1.Controls.Remove(x);
                }
            }

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Click += btnclick;
                    if (j == 0)
                    {
                        btn.Text = $"A{i+1}";
                        btn.BackColor = Color.LightBlue;
                        toolTip1.SetToolTip(btn, "25000");
                    }
                    else if (j == 1)
                    {
                        btn.Text = $"B{i+1}";
                        btn.BackColor = Color.LightGreen;
                        toolTip1.SetToolTip(btn, "30000");

                    }
                    else if (j == 2)
                    {
                        btn.Text = $"C{i+1}";
                        btn.BackColor = Color.Yellow;
                        toolTip1.SetToolTip(btn, "35000");

                    }
                    else if (j == 3)
                    {
                        btn.Text = $"D{i + 1}";
                        btn.BackColor = Color.LightPink;
                        toolTip1.SetToolTip(btn, "40000");

                    }
                    else if (j == 4)
                    {
                        btn.Text = $"E{i + 1}";
                        btn.BackColor = Color.HotPink;
                        toolTip1.SetToolTip(btn, "45000");


                    }
                    else if (j == 5)
                    {
                        btn.Text = $"F{i}";
                        btn.BackColor = Color.Orange;
                        toolTip1.SetToolTip(btn, "50000");

                    }
                    tableLayoutPanel1.Controls.Add(btn, i, j);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            re();
            label3.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
            re();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                    {
                        Control ctrl = tableLayoutPanel1.GetControlFromPosition(i, j);
                        if (ctrl != null)
                        {
                            if (ctrl.BackColor == Color.Green)
                            {
                                ctrl.BackColor = Color.Red;
                                ctrl.Enabled = false;
                   
                            }
                        }
                    }
                }
                tong = 0;
                label5.Text = "0";
            }
        }
    }
}
