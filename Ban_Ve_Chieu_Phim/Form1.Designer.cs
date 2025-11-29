namespace Ban_Ve_Chieu_Phim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel_GHE = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tienve = new System.Windows.Forms.TextBox();
            this.btn_dat = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(331, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "RẠP CHIẾU PHIM";
            // 
            // panel_GHE
            // 
            this.panel_GHE.Location = new System.Drawing.Point(12, 81);
            this.panel_GHE.Name = "panel_GHE";
            this.panel_GHE.Size = new System.Drawing.Size(897, 308);
            this.panel_GHE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền vé";
            // 
            // txt_tienve
            // 
            this.txt_tienve.Location = new System.Drawing.Point(682, 421);
            this.txt_tienve.Name = "txt_tienve";
            this.txt_tienve.Size = new System.Drawing.Size(227, 22);
            this.txt_tienve.TabIndex = 3;
            // 
            // btn_dat
            // 
            this.btn_dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dat.Location = new System.Drawing.Point(197, 489);
            this.btn_dat.Name = "btn_dat";
            this.btn_dat.Size = new System.Drawing.Size(146, 37);
            this.btn_dat.TabIndex = 4;
            this.btn_dat.Text = "Đặt Vé";
            this.btn_dat.UseVisualStyleBackColor = true;
            this.btn_dat.Click += new System.EventHandler(this.btn_dat_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(379, 489);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(147, 37);
            this.btn_huy.TabIndex = 5;
            this.btn_huy.Text = "Hủy Vé";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.Location = new System.Drawing.Point(547, 489);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(152, 37);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "Kết Thúc";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 582);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dat);
            this.Controls.Add(this.txt_tienve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_GHE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_GHE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tienve;
        private System.Windows.Forms.Button btn_dat;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_end;
    }
}

