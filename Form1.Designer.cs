namespace YouTobe_DWN
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
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mp3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chLittles = new System.Windows.Forms.CheckBox();
            this.chUppers = new System.Windows.Forms.CheckBox();
            this.chNumbers = new System.Windows.Forms.CheckBox();
            this.chSpecials = new System.Windows.Forms.CheckBox();
            this.lblPWD = new System.Windows.Forms.Label();
            this.chMistake = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(113, 33);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(41, 20);
            this.txtPWD.TabIndex = 0;
            this.txtPWD.Text = "9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mp3
            // 
            this.mp3.Location = new System.Drawing.Point(0, 0);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(104, 24);
            this.mp3.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jelszó Hosszúság:";
            // 
            // chLittles
            // 
            this.chLittles.AutoSize = true;
            this.chLittles.Location = new System.Drawing.Point(39, 102);
            this.chLittles.Name = "chLittles";
            this.chLittles.Size = new System.Drawing.Size(65, 17);
            this.chLittles.TabIndex = 4;
            this.chLittles.Text = "Kis Betű";
            this.chLittles.UseVisualStyleBackColor = true;
            //this.chLittles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chUppers
            // 
            this.chUppers.AutoSize = true;
            this.chUppers.Location = new System.Drawing.Point(146, 103);
            this.chUppers.Name = "chUppers";
            this.chUppers.Size = new System.Drawing.Size(76, 17);
            this.chUppers.TabIndex = 5;
            this.chUppers.Text = "Nagy Betű";
            this.chUppers.UseVisualStyleBackColor = true;
            // 
            // chNumbers
            // 
            this.chNumbers.AutoSize = true;
            this.chNumbers.Location = new System.Drawing.Point(254, 102);
            this.chNumbers.Name = "chNumbers";
            this.chNumbers.Size = new System.Drawing.Size(64, 17);
            this.chNumbers.TabIndex = 6;
            this.chNumbers.Text = "Számok";
            this.chNumbers.UseVisualStyleBackColor = true;
            // 
            // chSpecials
            // 
            this.chSpecials.AutoSize = true;
            this.chSpecials.Location = new System.Drawing.Point(341, 102);
            this.chSpecials.Name = "chSpecials";
            this.chSpecials.Size = new System.Drawing.Size(122, 17);
            this.chSpecials.TabIndex = 7;
            this.chSpecials.Text = "Speciális karakterek";
            this.chSpecials.UseVisualStyleBackColor = true;
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Location = new System.Drawing.Point(41, 196);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(79, 13);
            this.lblPWD.TabIndex = 8;
            this.lblPWD.Text = "Generált PWD:";
            // 
            // chMistake
            // 
            this.chMistake.AutoSize = true;
            this.chMistake.Location = new System.Drawing.Point(177, 130);
            this.chMistake.Name = "chMistake";
            this.chMistake.Size = new System.Drawing.Size(237, 17);
            this.chMistake.TabIndex = 9;
            this.chMistake.Text = "Téveszthető Karakterek elrejtése (0 - O ; I - l)";
            this.chMistake.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 247);
            this.Controls.Add(this.chMistake);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.chSpecials);
            this.Controls.Add(this.chNumbers);
            this.Controls.Add(this.chUppers);
            this.Controls.Add(this.chLittles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.mp3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPWD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton mp3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chLittles;
        private System.Windows.Forms.CheckBox chUppers;
        private System.Windows.Forms.CheckBox chNumbers;
        private System.Windows.Forms.CheckBox chSpecials;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.CheckBox chMistake;
    }
}

