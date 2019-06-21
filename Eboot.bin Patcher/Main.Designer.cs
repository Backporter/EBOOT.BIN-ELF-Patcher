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
            this.OPEN_ELF = new System.Windows.Forms.Button();
            this.PATCH_ELF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(148, 106);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(96, 23);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = true;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OPEN_ELF
            // 
            this.OPEN_ELF.Location = new System.Drawing.Point(148, 48);
            this.OPEN_ELF.Name = "OPEN_ELF";
            this.OPEN_ELF.Size = new System.Drawing.Size(96, 23);
            this.OPEN_ELF.TabIndex = 4;
            this.OPEN_ELF.Text = "Open PS4 ELF";
            this.OPEN_ELF.UseVisualStyleBackColor = true;
            this.OPEN_ELF.Click += new System.EventHandler(this.OPEN_ELF_Click);
            // 
            // PATCH_ELF
            // 
            this.PATCH_ELF.Location = new System.Drawing.Point(148, 77);
            this.PATCH_ELF.Name = "PATCH_ELF";
            this.PATCH_ELF.Size = new System.Drawing.Size(96, 23);
            this.PATCH_ELF.TabIndex = 13;
            this.PATCH_ELF.Text = "Patch PS4 ELF";
            this.PATCH_ELF.UseVisualStyleBackColor = true;
            this.PATCH_ELF.Click += new System.EventHandler(this.PATCH_ELF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 122);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Skyrim SE",
            "Fallout 4"});
            this.comboBox1.Location = new System.Drawing.Point(148, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(250, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 133);
            this.panel1.TabIndex = 21;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag And Drop Here";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(388, 166);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.OPEN_ELF);
            this.Controls.Add(this.PATCH_ELF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "PS4 EBOOT.BIN PATCHER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Credits;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OPEN_ELF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PATCH_ELF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

