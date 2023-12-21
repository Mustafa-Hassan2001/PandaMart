namespace PandaMart
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.INSERTNEWITEMbutton = new System.Windows.Forms.Button();
            this.DISCOUNTtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PRICEtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.INSERTNEWITEMbutton);
            this.panel1.Controls.Add(this.DISCOUNTtextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PRICEtextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NAMEtextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(211, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 257);
            this.panel1.TabIndex = 1;
            // 
            // INSERTNEWITEMbutton
            // 
            this.INSERTNEWITEMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTNEWITEMbutton.Location = new System.Drawing.Point(185, 195);
            this.INSERTNEWITEMbutton.Name = "INSERTNEWITEMbutton";
            this.INSERTNEWITEMbutton.Size = new System.Drawing.Size(127, 35);
            this.INSERTNEWITEMbutton.TabIndex = 7;
            this.INSERTNEWITEMbutton.Text = "INSERT";
            this.INSERTNEWITEMbutton.UseVisualStyleBackColor = true;
            this.INSERTNEWITEMbutton.Click += new System.EventHandler(this.INSERTNEWITEMbutton_Click);
            // 
            // DISCOUNTtextBox
            // 
            this.DISCOUNTtextBox.Location = new System.Drawing.Point(177, 150);
            this.DISCOUNTtextBox.Name = "DISCOUNTtextBox";
            this.DISCOUNTtextBox.Size = new System.Drawing.Size(200, 20);
            this.DISCOUNTtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discount:";
            // 
            // PRICEtextBox
            // 
            this.PRICEtextBox.Location = new System.Drawing.Point(177, 109);
            this.PRICEtextBox.Name = "PRICEtextBox";
            this.PRICEtextBox.Size = new System.Drawing.Size(200, 20);
            this.PRICEtextBox.TabIndex = 1;
            this.PRICEtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.Location = new System.Drawing.Point(177, 68);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(200, 20);
            this.NAMEtextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD ITEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button INSERTNEWITEMbutton;
        private System.Windows.Forms.TextBox DISCOUNTtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PRICEtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}