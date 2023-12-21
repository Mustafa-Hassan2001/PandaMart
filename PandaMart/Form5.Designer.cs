namespace PandaMart
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UPDATEbutton = new System.Windows.Forms.Button();
            this.DISCOUNTtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PRICEtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DELETEbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IDtextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DELETEbutton);
            this.panel1.Controls.Add(this.UPDATEbutton);
            this.panel1.Controls.Add(this.DISCOUNTtextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PRICEtextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NAMEtextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(228, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 253);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UPDATEbutton
            // 
            this.UPDATEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbutton.Location = new System.Drawing.Point(96, 201);
            this.UPDATEbutton.Name = "UPDATEbutton";
            this.UPDATEbutton.Size = new System.Drawing.Size(127, 35);
            this.UPDATEbutton.TabIndex = 7;
            this.UPDATEbutton.Text = "UPDATE";
            this.UPDATEbutton.UseVisualStyleBackColor = true;
            this.UPDATEbutton.Click += new System.EventHandler(this.INSERTNEWITEMbutton_Click);
            // 
            // DISCOUNTtextBox
            // 
            this.DISCOUNTtextBox.Location = new System.Drawing.Point(156, 158);
            this.DISCOUNTtextBox.Name = "DISCOUNTtextBox";
            this.DISCOUNTtextBox.Size = new System.Drawing.Size(200, 20);
            this.DISCOUNTtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discount:";
            // 
            // PRICEtextBox
            // 
            this.PRICEtextBox.Location = new System.Drawing.Point(157, 122);
            this.PRICEtextBox.Name = "PRICEtextBox";
            this.PRICEtextBox.Size = new System.Drawing.Size(200, 20);
            this.PRICEtextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.Location = new System.Drawing.Point(156, 90);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(200, 20);
            this.NAMEtextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDIT ITEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DELETEbutton
            // 
            this.DELETEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEbutton.Location = new System.Drawing.Point(229, 201);
            this.DELETEbutton.Name = "DELETEbutton";
            this.DELETEbutton.Size = new System.Drawing.Size(127, 35);
            this.DELETEbutton.TabIndex = 8;
            this.DELETEbutton.Text = "DELETE";
            this.DELETEbutton.UseVisualStyleBackColor = true;
            this.DELETEbutton.Click += new System.EventHandler(this.DELETEbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 209);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGrideView1_MouseDoubleClick);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(156, 56);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(200, 20);
            this.IDtextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UPDATEbutton;
        private System.Windows.Forms.TextBox DISCOUNTtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PRICEtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DELETEbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label5;
    }
}