﻿namespace caculator
{
    partial class FrmMain
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
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btndoidau = new System.Windows.Forms.Button();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.btnphantram = new System.Windows.Forms.Button();
            this.btnbang = new System.Windows.Forms.Button();
            this.btnthapphan = new System.Windows.Forms.Button();
            this.btnnho = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay.Location = new System.Drawing.Point(22, 18);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(201, 40);
            this.lbldisplay.TabIndex = 0;
            this.lbldisplay.Text = "0.";
            this.lbldisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(64, 245);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 35);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(63, 204);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(22, 204);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Nhapso);
            // 
            // btndoidau
            // 
            this.btndoidau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoidau.Location = new System.Drawing.Point(22, 245);
            this.btndoidau.Name = "btndoidau";
            this.btndoidau.Size = new System.Drawing.Size(35, 35);
            this.btndoidau.TabIndex = 17;
            this.btndoidau.Text = "-/+";
            this.btndoidau.UseVisualStyleBackColor = true;
            this.btndoidau.Click += new System.EventHandler(this.btndoidau_Click);
            // 
            // btncong
            // 
            this.btncong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncong.Location = new System.Drawing.Point(145, 122);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(36, 35);
            this.btncong.TabIndex = 6;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btntru
            // 
            this.btntru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntru.Location = new System.Drawing.Point(145, 163);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(36, 35);
            this.btntru.TabIndex = 11;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnnhan
            // 
            this.btnnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhan.Location = new System.Drawing.Point(145, 204);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(36, 35);
            this.btnnhan.TabIndex = 16;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(104, 122);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(36, 35);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(63, 122);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 35);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(22, 122);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(104, 163);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 35);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(63, 163);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 35);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(22, 163);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(104, 204);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 35);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Nhapso);
            // 
            // btnchia
            // 
            this.btnchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchia.Location = new System.Drawing.Point(145, 245);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(36, 35);
            this.btnchia.TabIndex = 20;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btncan
            // 
            this.btncan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(186, 163);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(36, 35);
            this.btncan.TabIndex = 12;
            this.btncan.Text = "√";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnphantram
            // 
            this.btnphantram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphantram.Location = new System.Drawing.Point(186, 122);
            this.btnphantram.Name = "btnphantram";
            this.btnphantram.Size = new System.Drawing.Size(36, 35);
            this.btnphantram.TabIndex = 7;
            this.btnphantram.Text = "%";
            this.btnphantram.UseVisualStyleBackColor = true;
            this.btnphantram.Click += new System.EventHandler(this.btnphantram_Click);
            // 
            // btnbang
            // 
            this.btnbang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbang.Location = new System.Drawing.Point(186, 204);
            this.btnbang.Name = "btnbang";
            this.btnbang.Size = new System.Drawing.Size(36, 76);
            this.btnbang.TabIndex = 21;
            this.btnbang.Text = "=";
            this.btnbang.UseVisualStyleBackColor = true;
            this.btnbang.Click += new System.EventHandler(this.btnbang_Click);
            // 
            // btnthapphan
            // 
            this.btnthapphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthapphan.Location = new System.Drawing.Point(104, 245);
            this.btnthapphan.Name = "btnthapphan";
            this.btnthapphan.Size = new System.Drawing.Size(36, 35);
            this.btnthapphan.TabIndex = 19;
            this.btnthapphan.Text = ".";
            this.btnthapphan.UseVisualStyleBackColor = true;
            // 
            // btnnho
            // 
            this.btnnho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnho.Location = new System.Drawing.Point(22, 81);
            this.btnnho.Name = "btnnho";
            this.btnnho.Size = new System.Drawing.Size(77, 35);
            this.btnnho.TabIndex = 1;
            this.btnnho.Text = "C";
            this.btnnho.UseVisualStyleBackColor = true;
            this.btnnho.Click += new System.EventHandler(this.btnNho_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(104, 81);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(118, 35);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "backspace";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Nhapso);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 295);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnnho);
            this.Controls.Add(this.btnthapphan);
            this.Controls.Add(this.btnbang);
            this.Controls.Add(this.btnphantram);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.btndoidau);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lbldisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Caculator";
            this.Click += new System.EventHandler(this.NhapPhepToan);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btndoidau;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnphantram;
        private System.Windows.Forms.Button btnbang;
        private System.Windows.Forms.Button btnthapphan;
        private System.Windows.Forms.Button btnnho;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button1;
    }
}

