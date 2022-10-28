namespace Calculator
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
            this.btCong = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNhan = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(186, 310);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(114, 48);
            this.btCong.TabIndex = 9;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(308, 210);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(312, 36);
            this.txtKetQua.TabIndex = 6;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(308, 153);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(312, 36);
            this.txtSoB.TabIndex = 7;
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(308, 91);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(312, 36);
            this.txtSoA.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số A";
            // 
            // btNhan
            // 
            this.btNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhan.Location = new System.Drawing.Point(476, 310);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(114, 48);
            this.btNhan.TabIndex = 9;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(327, 310);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(114, 48);
            this.btTru.TabIndex = 9;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChia.Location = new System.Drawing.Point(623, 310);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(114, 48);
            this.btChia.TabIndex = 9;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btChia;
    }
}

