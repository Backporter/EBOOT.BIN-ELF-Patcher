namespace Eboot.bin_Patcher
{
    partial class Updates
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ts = new System.Windows.Forms.CheckBox();
            this.NO = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eboot.bin_Patcher.Properties.Resources._67d967e46df207b2c8afb3e4c26ae805;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ts
            // 
            this.ts.AutoSize = true;
            this.ts.Location = new System.Drawing.Point(592, 17);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(29, 17);
            this.ts.TabIndex = 1;
            this.ts.Text = "t";
            this.ts.UseVisualStyleBackColor = true;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Checked = true;
            this.NO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NO.Location = new System.Drawing.Point(136, 61);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(63, 17);
            this.NO.TabIndex = 20;
            this.NO.Text = "Nothing";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Patch PS4 ELF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Open PS4 ELF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 136);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Updates";
            this.Text = "Updates";
            this.Load += new System.EventHandler(this.Updates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ts;
        private System.Windows.Forms.CheckBox NO;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}