namespace tes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.Button();
            this.x5 = new System.Windows.Forms.TextBox();
            this.x6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(139, 64);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(172, 27);
            this.x1.TabIndex = 0;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(139, 118);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(172, 27);
            this.x2.TabIndex = 0;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(61, 333);
            this.x3.Multiline = true;
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(349, 67);
            this.x3.TabIndex = 0;
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(155, 274);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(140, 26);
            this.x4.TabIndex = 1;
            this.x4.Text = "hiển thị";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.x4_Click);
            // 
            // x5
            // 
            this.x5.Location = new System.Drawing.Point(139, 161);
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(172, 27);
            this.x5.TabIndex = 0;
            // 
            // x6
            // 
            this.x6.Location = new System.Drawing.Point(139, 215);
            this.x6.Name = "x6";
            this.x6.Size = new System.Drawing.Size(172, 27);
            this.x6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sinh Viên";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x6);
            this.Controls.Add(this.x5);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.TextBox x5;
        private System.Windows.Forms.TextBox x6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

