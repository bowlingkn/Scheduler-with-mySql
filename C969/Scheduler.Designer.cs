
namespace C969
{
	partial class Scheduler
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabAppoinments = new System.Windows.Forms.TabPage();
			this.buttonMonthly = new System.Windows.Forms.Button();
			this.buttonWeekly = new System.Windows.Forms.Button();
			this.buttonAll = new System.Windows.Forms.Button();
			this.buttonDelete1 = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonAdd1 = new System.Windows.Forms.Button();
			this.dgvAppt = new System.Windows.Forms.DataGridView();
			this.tabCustomers = new System.Windows.Forms.TabPage();
			this.buttonDelete2 = new System.Windows.Forms.Button();
			this.buttonModify2 = new System.Windows.Forms.Button();
			this.buttonAdd2 = new System.Windows.Forms.Button();
			this.dgvCustomer = new System.Windows.Forms.DataGridView();
			this.tabReports = new System.Windows.Forms.TabPage();
			this.tbReport = new System.Windows.Forms.TextBox();
			this.dgvReport = new System.Windows.Forms.DataGridView();
			this.buttonReport3 = new System.Windows.Forms.Button();
			this.cbCustomer = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonReport2 = new System.Windows.Forms.Button();
			this.cbUser = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonReport1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabAppoinments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).BeginInit();
			this.tabCustomers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.tabReports.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabAppoinments);
			this.tabControl1.Controls.Add(this.tabCustomers);
			this.tabControl1.Controls.Add(this.tabReports);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(514, 325);
			this.tabControl1.TabIndex = 1;
			// 
			// tabAppoinments
			// 
			this.tabAppoinments.Controls.Add(this.buttonMonthly);
			this.tabAppoinments.Controls.Add(this.buttonWeekly);
			this.tabAppoinments.Controls.Add(this.buttonAll);
			this.tabAppoinments.Controls.Add(this.buttonDelete1);
			this.tabAppoinments.Controls.Add(this.buttonModify);
			this.tabAppoinments.Controls.Add(this.buttonAdd1);
			this.tabAppoinments.Controls.Add(this.dgvAppt);
			this.tabAppoinments.Location = new System.Drawing.Point(4, 22);
			this.tabAppoinments.Name = "tabAppoinments";
			this.tabAppoinments.Padding = new System.Windows.Forms.Padding(3);
			this.tabAppoinments.Size = new System.Drawing.Size(506, 299);
			this.tabAppoinments.TabIndex = 0;
			this.tabAppoinments.Text = "Appointments";
			this.tabAppoinments.UseVisualStyleBackColor = true;
			// 
			// buttonMonthly
			// 
			this.buttonMonthly.Location = new System.Drawing.Point(168, 6);
			this.buttonMonthly.Name = "buttonMonthly";
			this.buttonMonthly.Size = new System.Drawing.Size(75, 23);
			this.buttonMonthly.TabIndex = 6;
			this.buttonMonthly.Text = "This Month";
			this.buttonMonthly.UseVisualStyleBackColor = true;
			this.buttonMonthly.Click += new System.EventHandler(this.buttonMonthly_Click);
			// 
			// buttonWeekly
			// 
			this.buttonWeekly.Location = new System.Drawing.Point(87, 6);
			this.buttonWeekly.Name = "buttonWeekly";
			this.buttonWeekly.Size = new System.Drawing.Size(75, 23);
			this.buttonWeekly.TabIndex = 5;
			this.buttonWeekly.Text = "This Week";
			this.buttonWeekly.UseVisualStyleBackColor = true;
			this.buttonWeekly.Click += new System.EventHandler(this.buttonWeekly_Click);
			// 
			// buttonAll
			// 
			this.buttonAll.Location = new System.Drawing.Point(6, 6);
			this.buttonAll.Name = "buttonAll";
			this.buttonAll.Size = new System.Drawing.Size(75, 23);
			this.buttonAll.TabIndex = 4;
			this.buttonAll.Text = "All ";
			this.buttonAll.UseVisualStyleBackColor = true;
			this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
			// 
			// buttonDelete1
			// 
			this.buttonDelete1.Location = new System.Drawing.Point(425, 270);
			this.buttonDelete1.Name = "buttonDelete1";
			this.buttonDelete1.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete1.TabIndex = 3;
			this.buttonDelete1.Text = "Delete";
			this.buttonDelete1.UseVisualStyleBackColor = true;
			this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
			// 
			// buttonModify
			// 
			this.buttonModify.Location = new System.Drawing.Point(344, 270);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(75, 23);
			this.buttonModify.TabIndex = 2;
			this.buttonModify.Text = "Modify";
			this.buttonModify.UseVisualStyleBackColor = true;
			this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
			// 
			// buttonAdd1
			// 
			this.buttonAdd1.Location = new System.Drawing.Point(263, 270);
			this.buttonAdd1.Name = "buttonAdd1";
			this.buttonAdd1.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd1.TabIndex = 1;
			this.buttonAdd1.Text = "Add";
			this.buttonAdd1.UseVisualStyleBackColor = true;
			this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dgvAppt
			// 
			this.dgvAppt.AllowUserToAddRows = false;
			this.dgvAppt.AllowUserToDeleteRows = false;
			this.dgvAppt.AllowUserToResizeColumns = false;
			this.dgvAppt.AllowUserToResizeRows = false;
			this.dgvAppt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvAppt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppt.Location = new System.Drawing.Point(6, 35);
			this.dgvAppt.MultiSelect = false;
			this.dgvAppt.Name = "dgvAppt";
			this.dgvAppt.ReadOnly = true;
			this.dgvAppt.RowHeadersVisible = false;
			this.dgvAppt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvAppt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAppt.Size = new System.Drawing.Size(494, 229);
			this.dgvAppt.TabIndex = 0;
			// 
			// tabCustomers
			// 
			this.tabCustomers.Controls.Add(this.buttonDelete2);
			this.tabCustomers.Controls.Add(this.buttonModify2);
			this.tabCustomers.Controls.Add(this.buttonAdd2);
			this.tabCustomers.Controls.Add(this.dgvCustomer);
			this.tabCustomers.Location = new System.Drawing.Point(4, 22);
			this.tabCustomers.Name = "tabCustomers";
			this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
			this.tabCustomers.Size = new System.Drawing.Size(506, 299);
			this.tabCustomers.TabIndex = 1;
			this.tabCustomers.Text = "Customers";
			this.tabCustomers.UseVisualStyleBackColor = true;
			// 
			// buttonDelete2
			// 
			this.buttonDelete2.Location = new System.Drawing.Point(425, 270);
			this.buttonDelete2.Name = "buttonDelete2";
			this.buttonDelete2.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete2.TabIndex = 6;
			this.buttonDelete2.Text = "Delete";
			this.buttonDelete2.UseVisualStyleBackColor = true;
			this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click);
			// 
			// buttonModify2
			// 
			this.buttonModify2.Location = new System.Drawing.Point(344, 270);
			this.buttonModify2.Name = "buttonModify2";
			this.buttonModify2.Size = new System.Drawing.Size(75, 23);
			this.buttonModify2.TabIndex = 5;
			this.buttonModify2.Text = "Modify";
			this.buttonModify2.UseVisualStyleBackColor = true;
			this.buttonModify2.Click += new System.EventHandler(this.buttonModify2_Click);
			// 
			// buttonAdd2
			// 
			this.buttonAdd2.Location = new System.Drawing.Point(263, 270);
			this.buttonAdd2.Name = "buttonAdd2";
			this.buttonAdd2.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd2.TabIndex = 4;
			this.buttonAdd2.Text = "Add";
			this.buttonAdd2.UseVisualStyleBackColor = true;
			this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
			// 
			// dgvCustomer
			// 
			this.dgvCustomer.AllowUserToAddRows = false;
			this.dgvCustomer.AllowUserToDeleteRows = false;
			this.dgvCustomer.AllowUserToResizeColumns = false;
			this.dgvCustomer.AllowUserToResizeRows = false;
			this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomer.Location = new System.Drawing.Point(6, 6);
			this.dgvCustomer.MultiSelect = false;
			this.dgvCustomer.Name = "dgvCustomer";
			this.dgvCustomer.ReadOnly = true;
			this.dgvCustomer.RowHeadersVisible = false;
			this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomer.Size = new System.Drawing.Size(494, 258);
			this.dgvCustomer.TabIndex = 0;
			// 
			// tabReports
			// 
			this.tabReports.Controls.Add(this.tbReport);
			this.tabReports.Controls.Add(this.dgvReport);
			this.tabReports.Controls.Add(this.buttonReport3);
			this.tabReports.Controls.Add(this.cbCustomer);
			this.tabReports.Controls.Add(this.label7);
			this.tabReports.Controls.Add(this.label8);
			this.tabReports.Controls.Add(this.buttonReport2);
			this.tabReports.Controls.Add(this.cbUser);
			this.tabReports.Controls.Add(this.label6);
			this.tabReports.Controls.Add(this.buttonReport1);
			this.tabReports.Controls.Add(this.label5);
			this.tabReports.Controls.Add(this.cbYear);
			this.tabReports.Controls.Add(this.cbMonth);
			this.tabReports.Controls.Add(this.label4);
			this.tabReports.Controls.Add(this.label3);
			this.tabReports.Controls.Add(this.label2);
			this.tabReports.Controls.Add(this.cbType);
			this.tabReports.Controls.Add(this.label1);
			this.tabReports.Location = new System.Drawing.Point(4, 22);
			this.tabReports.Name = "tabReports";
			this.tabReports.Size = new System.Drawing.Size(506, 299);
			this.tabReports.TabIndex = 2;
			this.tabReports.Text = "Reports";
			this.tabReports.UseVisualStyleBackColor = true;
			// 
			// tbReport
			// 
			this.tbReport.Location = new System.Drawing.Point(204, 29);
			this.tbReport.Multiline = true;
			this.tbReport.Name = "tbReport";
			this.tbReport.ReadOnly = true;
			this.tbReport.Size = new System.Drawing.Size(296, 106);
			this.tbReport.TabIndex = 22;
			// 
			// dgvReport
			// 
			this.dgvReport.AllowUserToAddRows = false;
			this.dgvReport.AllowUserToDeleteRows = false;
			this.dgvReport.AllowUserToResizeColumns = false;
			this.dgvReport.AllowUserToResizeRows = false;
			this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReport.Location = new System.Drawing.Point(204, 140);
			this.dgvReport.MultiSelect = false;
			this.dgvReport.Name = "dgvReport";
			this.dgvReport.ReadOnly = true;
			this.dgvReport.RowHeadersVisible = false;
			this.dgvReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvReport.Size = new System.Drawing.Size(297, 150);
			this.dgvReport.TabIndex = 20;
			// 
			// buttonReport3
			// 
			this.buttonReport3.Location = new System.Drawing.Point(132, 261);
			this.buttonReport3.Name = "buttonReport3";
			this.buttonReport3.Size = new System.Drawing.Size(66, 23);
			this.buttonReport3.TabIndex = 19;
			this.buttonReport3.Text = "Check";
			this.buttonReport3.UseVisualStyleBackColor = true;
			this.buttonReport3.Click += new System.EventHandler(this.buttonReport3_Click);
			// 
			// cbCustomer
			// 
			this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCustomer.FormattingEnabled = true;
			this.cbCustomer.Location = new System.Drawing.Point(95, 234);
			this.cbCustomer.Name = "cbCustomer";
			this.cbCustomer.Size = new System.Drawing.Size(103, 21);
			this.cbCustomer.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 237);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Customer ID";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(5, 214);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(156, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Appointments by Customer";
			// 
			// buttonReport2
			// 
			this.buttonReport2.Location = new System.Drawing.Point(132, 187);
			this.buttonReport2.Name = "buttonReport2";
			this.buttonReport2.Size = new System.Drawing.Size(66, 23);
			this.buttonReport2.TabIndex = 15;
			this.buttonReport2.Text = "Check";
			this.buttonReport2.UseVisualStyleBackColor = true;
			this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
			// 
			// cbUser
			// 
			this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUser.FormattingEnabled = true;
			this.cbUser.Location = new System.Drawing.Point(95, 160);
			this.cbUser.Name = "cbUser";
			this.cbUser.Size = new System.Drawing.Size(103, 21);
			this.cbUser.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Username";
			// 
			// buttonReport1
			// 
			this.buttonReport1.Location = new System.Drawing.Point(132, 112);
			this.buttonReport1.Name = "buttonReport1";
			this.buttonReport1.Size = new System.Drawing.Size(66, 23);
			this.buttonReport1.TabIndex = 12;
			this.buttonReport1.Text = "Check";
			this.buttonReport1.UseVisualStyleBackColor = true;
			this.buttonReport1.Click += new System.EventHandler(this.buttonReport1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Appointments by User";
			// 
			// cbYear
			// 
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
			this.cbYear.Location = new System.Drawing.Point(77, 58);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(84, 21);
			this.cbYear.TabIndex = 10;
			// 
			// cbMonth
			// 
			this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonth.FormattingEnabled = true;
			this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "Decemeber"});
			this.cbMonth.Location = new System.Drawing.Point(77, 31);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(84, 21);
			this.cbMonth.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Year";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(249, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Number of appointments per month by type";
			// 
			// cbType
			// 
			this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(77, 85);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(121, 21);
			this.cbType.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Month";
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(442, 334);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// Scheduler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 360);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.tabControl1);
			this.Name = "Scheduler";
			this.Text = "Scheduler";
			this.Activated += new System.EventHandler(this.Scheduler_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scheduler_FormClosed);
			this.Shown += new System.EventHandler(this.Scheduler_Shown);
			this.tabControl1.ResumeLayout(false);
			this.tabAppoinments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).EndInit();
			this.tabCustomers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.tabReports.ResumeLayout(false);
			this.tabReports.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabAppoinments;
		private System.Windows.Forms.DataGridView dgvAppt;
		private System.Windows.Forms.TabPage tabCustomers;
		private System.Windows.Forms.DataGridView dgvCustomer;
		private System.Windows.Forms.TabPage tabReports;
		private System.Windows.Forms.Button buttonDelete1;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.Button buttonAdd1;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonDelete2;
		private System.Windows.Forms.Button buttonModify2;
		private System.Windows.Forms.Button buttonAdd2;
		private System.Windows.Forms.Button buttonMonthly;
		private System.Windows.Forms.Button buttonWeekly;
		private System.Windows.Forms.Button buttonAll;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonReport1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbUser;
		private System.Windows.Forms.Button buttonReport2;
		private System.Windows.Forms.DataGridView dgvReport;
		private System.Windows.Forms.Button buttonReport3;
		private System.Windows.Forms.ComboBox cbCustomer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbReport;
	}
}