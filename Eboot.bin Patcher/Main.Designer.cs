namespace Eboot.bin_Patcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Credits = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.F4 = new System.Windows.Forms.CheckBox();
            this.SSE = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(138, 62);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(94, 23);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = true;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open PS4 ELF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(138, 91);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(94, 23);
            this.Help.TabIndex = 6;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // F4
            // 
            this.F4.AutoSize = true;
            this.F4.Location = new System.Drawing.Point(238, 50);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(66, 17);
            this.F4.TabIndex = 10;
            this.F4.Text = "Fallout 4";
            this.F4.UseVisualStyleBackColor = true;
            // 
            // SSE
            // 
            this.SSE.AutoSize = true;
            this.SSE.Location = new System.Drawing.Point(238, 27);
            this.SSE.Name = "SSE";
            this.SSE.Size = new System.Drawing.Size(130, 17);
            this.SSE.TabIndex = 11;
            this.SSE.Text = "Skyrim Special Edition";
            this.SSE.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eboot.bin_Patcher.Properties.Resources._67d967e46df207b2c8afb3e4c26ae805;
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 128);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Patch PS4 ELF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Checked = true;
            this.NO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NO.Location = new System.Drawing.Point(238, 4);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(63, 17);
            this.NO.TabIndex = 14;
            this.NO.Text = "Nothing";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(372, 136);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SSE);
            this.Controls.Add(this.F4);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Credits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "PS4 EBOOT.BIN PATCHER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Credits;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.CheckBox F4;
        private System.Windows.Forms.CheckBox SSE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox NO;
    }
}

