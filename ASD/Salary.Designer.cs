namespace ASD
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SalaryDGV = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.ExcusedTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AbsTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PresTb = new System.Windows.Forms.TextBox();
            this.AttNumCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BonusTb = new System.Windows.Forms.TextBox();
            this.BonusIdCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BalanceTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BaseSalaryTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.AdvanceTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SalDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpIdCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Add new Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SalaryDGV
            // 
            this.SalaryDGV.BackgroundColor = System.Drawing.Color.DimGray;
            this.SalaryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryDGV.Location = new System.Drawing.Point(4, 691);
            this.SalaryDGV.Name = "SalaryDGV";
            this.SalaryDGV.Size = new System.Drawing.Size(243, 142);
            this.SalaryDGV.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(27, 567);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 16);
            this.label17.TabIndex = 72;
            this.label17.Text = "Excused";
            // 
            // ExcusedTb
            // 
            this.ExcusedTb.Enabled = false;
            this.ExcusedTb.Location = new System.Drawing.Point(30, 586);
            this.ExcusedTb.Name = "ExcusedTb";
            this.ExcusedTb.Size = new System.Drawing.Size(203, 20);
            this.ExcusedTb.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(27, 525);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 70;
            this.label16.Text = "Absence";
            // 
            // AbsTb
            // 
            this.AbsTb.Enabled = false;
            this.AbsTb.Location = new System.Drawing.Point(30, 544);
            this.AbsTb.Name = "AbsTb";
            this.AbsTb.Size = new System.Drawing.Size(203, 20);
            this.AbsTb.TabIndex = 69;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(25, 483);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 68;
            this.label15.Text = "Presence";
            // 
            // PresTb
            // 
            this.PresTb.Enabled = false;
            this.PresTb.Location = new System.Drawing.Point(28, 502);
            this.PresTb.Name = "PresTb";
            this.PresTb.Size = new System.Drawing.Size(203, 20);
            this.PresTb.TabIndex = 67;
            // 
            // AttNumCb
            // 
            this.AttNumCb.FormattingEnabled = true;
            this.AttNumCb.Location = new System.Drawing.Point(28, 459);
            this.AttNumCb.Name = "AttNumCb";
            this.AttNumCb.Size = new System.Drawing.Size(203, 21);
            this.AttNumCb.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Attendance";
            // 
            // BonusTb
            // 
            this.BonusTb.Enabled = false;
            this.BonusTb.Location = new System.Drawing.Point(28, 284);
            this.BonusTb.Name = "BonusTb";
            this.BonusTb.Size = new System.Drawing.Size(203, 20);
            this.BonusTb.TabIndex = 64;
            // 
            // BonusIdCb
            // 
            this.BonusIdCb.FormattingEnabled = true;
            this.BonusIdCb.Location = new System.Drawing.Point(28, 257);
            this.BonusIdCb.Name = "BonusIdCb";
            this.BonusIdCb.Size = new System.Drawing.Size(203, 21);
            this.BonusIdCb.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Balance";
            // 
            // BalanceTb
            // 
            this.BalanceTb.Location = new System.Drawing.Point(28, 368);
            this.BalanceTb.Name = "BalanceTb";
            this.BalanceTb.Size = new System.Drawing.Size(205, 20);
            this.BalanceTb.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Basic Salary";
            // 
            // BaseSalaryTb
            // 
            this.BaseSalaryTb.Enabled = false;
            this.BaseSalaryTb.Location = new System.Drawing.Point(28, 208);
            this.BaseSalaryTb.Name = "BaseSalaryTb";
            this.BaseSalaryTb.Size = new System.Drawing.Size(203, 20);
            this.BaseSalaryTb.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(173, 638);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 58;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(102, 638);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Advance";
            // 
            // AdvanceTb
            // 
            this.AdvanceTb.Location = new System.Drawing.Point(28, 326);
            this.AdvanceTb.Name = "AdvanceTb";
            this.AdvanceTb.Size = new System.Drawing.Size(203, 20);
            this.AdvanceTb.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 53;
            this.label13.Text = "Bonus";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "Name";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Enabled = false;
            this.EmpNameTb.Location = new System.Drawing.Point(28, 166);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(203, 20);
            this.EmpNameTb.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "Period";
            // 
            // SalDate
            // 
            this.SalDate.Location = new System.Drawing.Point(28, 409);
            this.SalDate.Name = "SalDate";
            this.SalDate.Size = new System.Drawing.Size(205, 20);
            this.SalDate.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Employee ID";
            // 
            // EmpIdCb
            // 
            this.EmpIdCb.FormattingEnabled = true;
            this.EmpIdCb.Location = new System.Drawing.Point(26, 123);
            this.EmpIdCb.Name = "EmpIdCb";
            this.EmpIdCb.Size = new System.Drawing.Size(203, 21);
            this.EmpIdCb.TabIndex = 47;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(268, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalaryDGV);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ExcusedTb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AbsTb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PresTb);
            this.Controls.Add(this.AttNumCb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BonusTb);
            this.Controls.Add(this.BonusIdCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BalanceTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BaseSalaryTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AdvanceTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SalDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpIdCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView SalaryDGV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ExcusedTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AbsTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PresTb;
        private System.Windows.Forms.ComboBox AttNumCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BonusTb;
        private System.Windows.Forms.ComboBox BonusIdCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BalanceTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BaseSalaryTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AdvanceTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker SalDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EmpIdCb;
    }
}