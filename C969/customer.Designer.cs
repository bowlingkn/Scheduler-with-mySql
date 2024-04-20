
namespace C969
{
	partial class customer
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCountry = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(263, 203);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(120, 41);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(100, 20);
			this.tbName.TabIndex = 1;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(79, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Phone Number";
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(120, 67);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(100, 20);
			this.tbPhone.TabIndex = 3;
			this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Address";
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(120, 93);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(100, 20);
			this.tbAddress.TabIndex = 5;
			this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(90, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "City";
			// 
			// tbCity
			// 
			this.tbCity.Location = new System.Drawing.Point(120, 119);
			this.tbCity.Name = "tbCity";
			this.tbCity.Size = new System.Drawing.Size(100, 20);
			this.tbCity.TabIndex = 7;
			this.tbCity.TextChanged += new System.EventHandler(this.tbCity_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Country";
			// 
			// tbCountry
			// 
			this.tbCountry.Location = new System.Drawing.Point(120, 145);
			this.tbCountry.Name = "tbCountry";
			this.tbCountry.Size = new System.Drawing.Size(100, 20);
			this.tbCountry.TabIndex = 9;
			this.tbCountry.TextChanged += new System.EventHandler(this.tbCountry_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(227, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "(ex. 111-1111)";
			// 
			// customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 238);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbCountry);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbCity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.buttonSave);
			this.Name = "customer";
			this.Text = "customer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbCountry;
		private System.Windows.Forms.Label label6;
	}
}