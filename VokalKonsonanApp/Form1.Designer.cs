namespace VokalKonsonanApp
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
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblJumlahTotal = new System.Windows.Forms.Label();
            this.lblJumlahKonsonan = new System.Windows.Forms.Label();
            this.lblJumlahVokal = new System.Windows.Forms.Label();
            this.lblKonsonan = new System.Windows.Forms.Label();
            this.lblVokal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type any statement:";
            // 
            // txtStatement
            // 
            this.txtStatement.Location = new System.Drawing.Point(26, 35);
            this.txtStatement.Multiline = true;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(311, 113);
            this.txtStatement.TabIndex = 1;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(259, 154);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(78, 40);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Huruf Vokal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Huruf Konsonan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jumlah Huruf Vokal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jumlah Huruf Konsonan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Jumlah Huruf Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = ":";
            // 
            // lblJumlahTotal
            // 
            this.lblJumlahTotal.AutoSize = true;
            this.lblJumlahTotal.Location = new System.Drawing.Point(152, 329);
            this.lblJumlahTotal.Name = "lblJumlahTotal";
            this.lblJumlahTotal.Size = new System.Drawing.Size(74, 13);
            this.lblJumlahTotal.TabIndex = 18;
            this.lblJumlahTotal.Text = "lblJumlahTotal";
            // 
            // lblJumlahKonsonan
            // 
            this.lblJumlahKonsonan.AutoSize = true;
            this.lblJumlahKonsonan.Location = new System.Drawing.Point(152, 305);
            this.lblJumlahKonsonan.Name = "lblJumlahKonsonan";
            this.lblJumlahKonsonan.Size = new System.Drawing.Size(98, 13);
            this.lblJumlahKonsonan.TabIndex = 17;
            this.lblJumlahKonsonan.Text = "lblJumlahKonsonan";
            // 
            // lblJumlahVokal
            // 
            this.lblJumlahVokal.AutoSize = true;
            this.lblJumlahVokal.Location = new System.Drawing.Point(152, 281);
            this.lblJumlahVokal.Name = "lblJumlahVokal";
            this.lblJumlahVokal.Size = new System.Drawing.Size(77, 13);
            this.lblJumlahVokal.TabIndex = 16;
            this.lblJumlahVokal.Text = "lblJumlahVokal";
            // 
            // lblKonsonan
            // 
            this.lblKonsonan.AutoSize = true;
            this.lblKonsonan.Location = new System.Drawing.Point(152, 257);
            this.lblKonsonan.Name = "lblKonsonan";
            this.lblKonsonan.Size = new System.Drawing.Size(65, 13);
            this.lblKonsonan.TabIndex = 15;
            this.lblKonsonan.Text = "lblKonsonan";
            // 
            // lblVokal
            // 
            this.lblVokal.AutoSize = true;
            this.lblVokal.Location = new System.Drawing.Point(152, 233);
            this.lblVokal.Name = "lblVokal";
            this.lblVokal.Size = new System.Drawing.Size(44, 13);
            this.lblVokal.TabIndex = 14;
            this.lblVokal.Text = "lblVokal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 404);
            this.Controls.Add(this.lblJumlahTotal);
            this.Controls.Add(this.lblJumlahKonsonan);
            this.Controls.Add(this.lblJumlahVokal);
            this.Controls.Add(this.lblKonsonan);
            this.Controls.Add(this.lblVokal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtStatement);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menghitung Jumlah Huruf Vokal dan Konsonan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblJumlahTotal;
        private System.Windows.Forms.Label lblJumlahKonsonan;
        private System.Windows.Forms.Label lblJumlahVokal;
        private System.Windows.Forms.Label lblKonsonan;
        private System.Windows.Forms.Label lblVokal;
    }
}

