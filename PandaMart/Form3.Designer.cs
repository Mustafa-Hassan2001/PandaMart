namespace PandaMart
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FIRSTNAMEtextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LASTNAMEtextBox = new System.Windows.Forms.TextBox();
            this.ADDRESStextBox = new System.Windows.Forms.TextBox();
            this.EMAILtextBox = new System.Windows.Forms.TextBox();
            this.PASSWORDtextBox = new System.Windows.Forms.TextBox();
            this.CONFIRMPASStextBox = new System.Windows.Forms.TextBox();
            this.AGEnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GENDERcomboBox = new System.Windows.Forms.ComboBox();
            this.SIGNUPbutton = new System.Windows.Forms.Button();
            this.RESETbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGEnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGNUP FORM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name: ";
            // 
            // FIRSTNAMEtextBox
            // 
            this.FIRSTNAMEtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FIRSTNAMEtextBox.Location = new System.Drawing.Point(157, 11);
            this.FIRSTNAMEtextBox.Name = "FIRSTNAMEtextBox";
            this.FIRSTNAMEtextBox.Size = new System.Drawing.Size(208, 20);
            this.FIRSTNAMEtextBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.3494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.6506F));
            this.tableLayoutPanel1.Controls.Add(this.AGEnumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CONFIRMPASStextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.PASSWORDtextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EMAILtextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ADDRESStextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LASTNAMEtextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FIRSTNAMEtextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.GENDERcomboBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(237, 203);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 343);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 40);
            this.label9.TabIndex = 10;
            this.label9.Text = "Confirm Password: ";
            // 
            // LASTNAMEtextBox
            // 
            this.LASTNAMEtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LASTNAMEtextBox.Location = new System.Drawing.Point(157, 53);
            this.LASTNAMEtextBox.Name = "LASTNAMEtextBox";
            this.LASTNAMEtextBox.Size = new System.Drawing.Size(208, 20);
            this.LASTNAMEtextBox.TabIndex = 11;
            // 
            // ADDRESStextBox
            // 
            this.ADDRESStextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ADDRESStextBox.Location = new System.Drawing.Point(157, 171);
            this.ADDRESStextBox.Multiline = true;
            this.ADDRESStextBox.Name = "ADDRESStextBox";
            this.ADDRESStextBox.Size = new System.Drawing.Size(208, 36);
            this.ADDRESStextBox.TabIndex = 14;
            // 
            // EMAILtextBox
            // 
            this.EMAILtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EMAILtextBox.Location = new System.Drawing.Point(157, 221);
            this.EMAILtextBox.Name = "EMAILtextBox";
            this.EMAILtextBox.Size = new System.Drawing.Size(208, 20);
            this.EMAILtextBox.TabIndex = 15;
            // 
            // PASSWORDtextBox
            // 
            this.PASSWORDtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PASSWORDtextBox.Location = new System.Drawing.Point(157, 263);
            this.PASSWORDtextBox.Name = "PASSWORDtextBox";
            this.PASSWORDtextBox.Size = new System.Drawing.Size(208, 20);
            this.PASSWORDtextBox.TabIndex = 16;
            this.PASSWORDtextBox.UseSystemPasswordChar = true;
            // 
            // CONFIRMPASStextBox
            // 
            this.CONFIRMPASStextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CONFIRMPASStextBox.Location = new System.Drawing.Point(157, 308);
            this.CONFIRMPASStextBox.Name = "CONFIRMPASStextBox";
            this.CONFIRMPASStextBox.Size = new System.Drawing.Size(208, 20);
            this.CONFIRMPASStextBox.TabIndex = 17;
            this.CONFIRMPASStextBox.UseSystemPasswordChar = true;
            // 
            // AGEnumericUpDown
            // 
            this.AGEnumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AGEnumericUpDown.Location = new System.Drawing.Point(157, 95);
            this.AGEnumericUpDown.Name = "AGEnumericUpDown";
            this.AGEnumericUpDown.Size = new System.Drawing.Size(208, 20);
            this.AGEnumericUpDown.TabIndex = 5;
            // 
            // GENDERcomboBox
            // 
            this.GENDERcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GENDERcomboBox.FormattingEnabled = true;
            this.GENDERcomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GENDERcomboBox.Location = new System.Drawing.Point(157, 136);
            this.GENDERcomboBox.Name = "GENDERcomboBox";
            this.GENDERcomboBox.Size = new System.Drawing.Size(208, 21);
            this.GENDERcomboBox.TabIndex = 18;
            // 
            // SIGNUPbutton
            // 
            this.SIGNUPbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNUPbutton.Location = new System.Drawing.Point(352, 556);
            this.SIGNUPbutton.Name = "SIGNUPbutton";
            this.SIGNUPbutton.Size = new System.Drawing.Size(109, 44);
            this.SIGNUPbutton.TabIndex = 5;
            this.SIGNUPbutton.Text = "SIGNUP";
            this.SIGNUPbutton.UseVisualStyleBackColor = true;
            this.SIGNUPbutton.Click += new System.EventHandler(this.SIGNUPbutton_Click);
            // 
            // RESETbutton
            // 
            this.RESETbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETbutton.Location = new System.Drawing.Point(467, 556);
            this.RESETbutton.Name = "RESETbutton";
            this.RESETbutton.Size = new System.Drawing.Size(109, 44);
            this.RESETbutton.TabIndex = 6;
            this.RESETbutton.Text = "RESET";
            this.RESETbutton.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 602);
            this.Controls.Add(this.RESETbutton);
            this.Controls.Add(this.SIGNUPbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGEnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIRSTNAMEtextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown AGEnumericUpDown;
        private System.Windows.Forms.TextBox CONFIRMPASStextBox;
        private System.Windows.Forms.TextBox PASSWORDtextBox;
        private System.Windows.Forms.TextBox EMAILtextBox;
        private System.Windows.Forms.TextBox ADDRESStextBox;
        private System.Windows.Forms.TextBox LASTNAMEtextBox;
        private System.Windows.Forms.ComboBox GENDERcomboBox;
        private System.Windows.Forms.Button SIGNUPbutton;
        private System.Windows.Forms.Button RESETbutton;
    }
}