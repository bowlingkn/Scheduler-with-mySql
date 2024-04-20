
namespace C969
{
	partial class appointment
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.tbCustomer = new System.Windows.Forms.TextBox();
			this.tbType = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.dtpEnd = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Customer ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "User ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(78, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(80, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Start";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(228, 203);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// tbCustomer
			// 
			this.tbCustomer.Location = new System.Drawing.Point(115, 46);
			this.tbCustomer.Name = "tbCustomer";
			this.tbCustomer.Size = new System.Drawing.Size(100, 20);
			this.tbCustomer.TabIndex = 10;
			this.tbCustomer.TextChanged += new System.EventHandler(this.tbCustomer_TextChanged);
			// 
			// tbType
			// 
			this.tbType.Location = new System.Drawing.Point(115, 98);
			this.tbType.Name = "tbType";
			this.tbType.Size = new System.Drawing.Size(100, 20);
			this.tbType.TabIndex = 12;
			this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(115, 72);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(100, 20);
			this.tbUser.TabIndex = 13;
			this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(83, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "End";
			// 
			// dtpStart
			// 
			this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStart.Location = new System.Drawing.Point(115, 124);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.Size = new System.Drawing.Size(188, 20);
			this.dtpStart.TabIndex = 16;
			// 
			// dtpEnd
			// 
			this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEnd.Location = new System.Drawing.Point(115, 150);
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.Size = new System.Drawing.Size(188, 20);
			this.dtpEnd.TabIndex = 17;
			// 
			// appointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 238);
			this.Controls.Add(this.dtpEnd);
			this.Controls.Add(this.dtpStart);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.tbType);
			this.Controls.Add(this.tbCustomer);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "appointment";
			this.Text = "Appointment Information";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox tbCustomer;
		private System.Windows.Forms.TextBox tbType;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpStart;
		private System.Windows.Forms.DateTimePicker dtpEnd;
	}
}