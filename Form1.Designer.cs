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
            this.label1 = new System.Windows.Forms.Label();
            this.chLittles = new System.Windows.Forms.CheckBox();
            this.chUppers = new System.Windows.Forms.CheckBox();
            this.chNumbers = new System.Windows.Forms.CheckBox();
            this.chSpecials = new System.Windows.Forms.CheckBox();
            this.lblPWD = new System.Windows.Forms.Label();
            this.chMistake = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWDDB = new System.Windows.Forms.TextBox();
            this.lstPWD = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(190, 6);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(53, 22);
            this.txtPWD.TabIndex = 0;
            this.txtPWD.Text = "9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jelszó Hosszúság (min: 9):";
            // 
            // chLittles
            // 
            this.chLittles.AutoSize = true;
            this.chLittles.Location = new System.Drawing.Point(13, 78);
            this.chLittles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chLittles.Name = "chLittles";
            this.chLittles.Size = new System.Drawing.Size(77, 20);
            this.chLittles.TabIndex = 4;
            this.chLittles.Text = "Kis Betű";
            this.chLittles.UseVisualStyleBackColor = true;
            // 
            // chUppers
            // 
            this.chUppers.AutoSize = true;
            this.chUppers.Location = new System.Drawing.Point(105, 78);
            this.chUppers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chUppers.Name = "chUppers";
            this.chUppers.Size = new System.Drawing.Size(92, 20);
            this.chUppers.TabIndex = 5;
            this.chUppers.Text = "Nagy Betű";
            this.chUppers.UseVisualStyleBackColor = true;
            // 
            // chNumbers
            // 
            this.chNumbers.AutoSize = true;
            this.chNumbers.Location = new System.Drawing.Point(215, 78);
            this.chNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chNumbers.Name = "chNumbers";
            this.chNumbers.Size = new System.Drawing.Size(78, 20);
            this.chNumbers.TabIndex = 6;
            this.chNumbers.Text = "Számok";
            this.chNumbers.UseVisualStyleBackColor = true;
            // 
            // chSpecials
            // 
            this.chSpecials.AutoSize = true;
            this.chSpecials.Location = new System.Drawing.Point(301, 78);
            this.chSpecials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chSpecials.Name = "chSpecials";
            this.chSpecials.Size = new System.Drawing.Size(152, 20);
            this.chSpecials.TabIndex = 7;
            this.chSpecials.Text = "Speciális karakterek";
            this.chSpecials.UseVisualStyleBackColor = true;
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Location = new System.Drawing.Point(55, 241);
            this.lblPWD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(96, 16);
            this.lblPWD.TabIndex = 8;
            this.lblPWD.Text = "Generált PWD:";
            // 
            // chMistake
            // 
            this.chMistake.AutoSize = true;
            this.chMistake.Location = new System.Drawing.Point(105, 106);
            this.chMistake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chMistake.Name = "chMistake";
            this.chMistake.Size = new System.Drawing.Size(289, 20);
            this.chMistake.TabIndex = 9;
            this.chMistake.Text = "Téveszthető Karakterek elrejtése (0 - O ; I - l)";
            this.chMistake.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jelszavak száma (1-15db):";
            // 
            // txtPWDDB
            // 
            this.txtPWDDB.Location = new System.Drawing.Point(189, 37);
            this.txtPWDDB.Name = "txtPWDDB";
            this.txtPWDDB.Size = new System.Drawing.Size(54, 22);
            this.txtPWDDB.TabIndex = 11;
            this.txtPWDDB.Text = "1";
            // 
            // lstPWD
            // 
            this.lstPWD.FormattingEnabled = true;
            this.lstPWD.ItemHeight = 16;
            this.lstPWD.Location = new System.Drawing.Point(460, 14);
            this.lstPWD.Name = "lstPWD";
            this.lstPWD.Size = new System.Drawing.Size(201, 276);
            this.lstPWD.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 304);
            this.Controls.Add(this.lstPWD);
            this.Controls.Add(this.txtPWDDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chMistake);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.chSpecials);
            this.Controls.Add(this.chNumbers);
            this.Controls.Add(this.chUppers);
            this.Controls.Add(this.chLittles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPWD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chLittles;
        private System.Windows.Forms.CheckBox chUppers;
        private System.Windows.Forms.CheckBox chNumbers;
        private System.Windows.Forms.CheckBox chSpecials;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.CheckBox chMistake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPWDDB;
        private System.Windows.Forms.ListBox lstPWD;
    }
}

