namespace TP_MODUL3_103022400066
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelOutput = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSama = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
            this.labelOutput.Location = new System.Drawing.Point(12, 12);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(276, 45);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "Label Output";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn1.Location = new System.Drawing.Point(12, 70);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 50);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn2.Location = new System.Drawing.Point(104, 70);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 50);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn3.Location = new System.Drawing.Point(208, 70);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 50);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn4.Location = new System.Drawing.Point(12, 132);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 50);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn5.Location = new System.Drawing.Point(104, 132);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 50);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn6.Location = new System.Drawing.Point(208, 132);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 50);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn7.Location = new System.Drawing.Point(12, 194);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 50);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn8.Location = new System.Drawing.Point(104, 194);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 50);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btnAngka_Click);

            this.btn9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn9.Location = new System.Drawing.Point(208, 194);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 50);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btnAngka_Click);

            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnTambah.Location = new System.Drawing.Point(12, 256);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(80, 50);
            this.btnTambah.Text = "+";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            this.btn0.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn0.Location = new System.Drawing.Point(104, 256);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 50);
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btnAngka_Click);

            this.btnSama.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSama.Location = new System.Drawing.Point(208, 256);
            this.btnSama.Name = "btnSama";
            this.btnSama.Size = new System.Drawing.Size(80, 50);
            this.btnSama.Text = "=";
            this.btnSama.Click += new System.EventHandler(this.btnSama_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 325);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnSama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Sederhana";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSama;
    }
}