namespace ASD
{
    partial class Attendances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendances));
            this.AttendanceDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PresenceTb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ExcusedTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AbsTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AttDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpIdCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceDGV
            // 
            this.AttendanceDGV.BackgroundColor = System.Drawing.Color.DimGray;
            this.AttendanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AttendanceDGV.Location = new System.Drawing.Point(1, 427);
            this.AttendanceDGV.Name = "AttendanceDGV";
            this.AttendanceDGV.Size = new System.Drawing.Size(249, 137);
            this.AttendanceDGV.TabIndex = 50;
            this.AttendanceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Present";
            // 
            // PresenceTb
            // 
            this.PresenceTb.Location = new System.Drawing.Point(28, 189);
            this.PresenceTb.Name = "PresenceTb";
            this.PresenceTb.Size = new System.Drawing.Size(203, 20);
            this.PresenceTb.TabIndex = 48;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Blue;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Location = new System.Drawing.Point(169, 362);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(62, 23);
            this.DeleteBtn.TabIndex = 47;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Blue;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Location = new System.Drawing.Point(97, 362);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(62, 23);
            this.EditBtn.TabIndex = 46;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Blue;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Location = new System.Drawing.Point(26, 362);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(62, 23);
            this.SaveBtn.TabIndex = 45;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Excused";
            // 
            // ExcusedTb
            // 
            this.ExcusedTb.Location = new System.Drawing.Point(28, 273);
            this.ExcusedTb.Name = "ExcusedTb";
            this.ExcusedTb.Size = new System.Drawing.Size(203, 20);
            this.ExcusedTb.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Absent";
            // 
            // AbsTb
            // 
            this.AbsTb.Location = new System.Drawing.Point(28, 231);
            this.AbsTb.Name = "AbsTb";
            this.AbsTb.Size = new System.Drawing.Size(203, 20);
            this.AbsTb.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Name";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Enabled = false;
            this.EmpNameTb.Location = new System.Drawing.Point(28, 147);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(203, 20);
            this.EmpNameTb.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Period";
            // 
            // AttDate
            // 
            this.AttDate.Location = new System.Drawing.Point(26, 313);
            this.AttDate.Name = "AttDate";
            this.AttDate.Size = new System.Drawing.Size(205, 20);
            this.AttDate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Employee ID";
            // 
            // EmpIdCb
            // 
            this.EmpIdCb.FormattingEnabled = true;
            this.EmpIdCb.Items.AddRange(new object[] {
            " Male",
            "Female",
            "Other"});
            this.EmpIdCb.Location = new System.Drawing.Point(26, 104);
            this.EmpIdCb.Name = "EmpIdCb";
            this.EmpIdCb.Size = new System.Drawing.Size(205, 21);
            this.EmpIdCb.TabIndex = 35;
            this.EmpIdCb.SelectionChangeCommitted += new System.EventHandler(this.EmpIdCb_SelectionChangeCommitted);
            this.EmpIdCb.SelectedValueChanged += new System.EventHandler(this.EmpIdCb_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Attendances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(268, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttendanceDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PresenceTb);
            this.Controls.Add(this.EmpIdCb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AttDate);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.ExcusedTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AbsTb);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendances";
            this.Text = "Attendances";
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PresenceTb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ExcusedTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AbsTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker AttDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EmpIdCb;
        private System.Windows.Forms.DataGridView AttendanceDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}