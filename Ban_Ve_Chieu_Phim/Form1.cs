using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ban_Ve_Chieu_Phim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            string tienve = txt_tienve.Text;
            var a = MessageBox.Show($"Tong tien ve la : {tienve}." +
                "Ban co muon thanh toan?", "Thong Bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                foreach (Control c in panel_GHE.Controls)
                {
                    if (c is Button)
                    {
                        Button btn = (Button)c;
                        if (btn.BackColor == Color.Yellow)
                        {
                            btn.BackColor = Color.Aqua;
                        }
                    }

                }
                txt_tienve.Text = "0";
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel_GHE.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    if (btn.BackColor == Color.Yellow)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }
            txt_tienve.Text = "0";
        }
        private void btn_GHE_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Yellow;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Aqua)
            {
                MessageBox.Show("Ghế đã được đặt, vui lòng chọn ghế khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Tinh_Tienve();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }

        private void Tinh_Tienve()
        {
            List<double> gia = new List<double>()
            { 100000, 120000, 150000, 180000, 200000 };
            double tongtien = 0;
            foreach (Control c in panel_GHE.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    if (btn.BackColor == Color.Yellow)
                    {
                        int hang = btn.Name[4] - '0';
                        if (hang < gia.Count)
                        {
                            tongtien += gia[hang];
                        }
                        else
                            tongtien += gia[gia.Count - 1];
                    }
                }
            }
            txt_tienve.Text = tongtien.ToString("N0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int so_hang = 4, so_cot = 6;
            int chdai_ghe = 50, chcao_ghe = 50;
            int kcach = 10;
            for (int i = 0; i < so_hang; i++)
            {
                for (int j = 0; j < so_cot; j++)
                {
                    Button btn = new Button();
                    btn.Size = new System.Drawing.Size(chdai_ghe, chcao_ghe);
                    btn.Location = new System.Drawing.Point(
                        j * (chdai_ghe + kcach) + 12,
                        i * (chcao_ghe + kcach) + 12);
                    btn.BackColor = Color.White;
                    btn.Name = $"btn_{i}_{j}";
                    btn.Text = (char)('A' + i) + (j + 1).ToString();
                    btn.Click += new System.EventHandler(this.btn_GHE_Click);
                    panel_GHE.Controls.Add(btn);

                }
            }

            // chinh lai size cho panel
            panel_GHE.Size = new System.Drawing.Size(
                so_cot * (chdai_ghe + kcach) + 14,
                so_hang * (chcao_ghe + kcach) + 14
                );

            //chinh lai form
            this.Size = new System.Drawing.Size(
                panel_GHE.Size.Width + 60,
                panel_GHE.Size.Height + 200
                );

            // Doi chu man anh
            label1.Left = (this.Width - label1.Width) / 2;

            //Doi chu tong tien ve
            txt_tienve.Left = panel_GHE.Width - txt_tienve.Width - 12;
            txt_tienve.Top = panel_GHE.Bottom + 16;
            label2.Left = txt_tienve.Left - label2.Width - 10;
            label2.Top = txt_tienve.Top + 4;

            // doi 3 nut bam
            //btn_huy.Left = this.Width / 2 - btn_huy.Width;
            btn_huy.Left  = panel_GHE.Right -btn_end.Width - btn_huy.Width -15;
            btn_huy.Top = panel_GHE.Bottom + 60;
            btn_dat.Left = btn_huy.Left - btn_dat.Width  -20;
            btn_dat.Top = btn_huy.Top;

            btn_end.Left = panel_GHE.Right -btn_end.Width;
            btn_end.Top = btn_huy.Top;
        }
    } 
    }
