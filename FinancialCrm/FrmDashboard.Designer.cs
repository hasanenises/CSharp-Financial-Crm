namespace FinancialCrm
{
	partial class FrmDashboard
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.btnCategory = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnExpenses = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotalBalance = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblBillTitle = new System.Windows.Forms.Label();
			this.lblBillAmount = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCategory
			// 
			this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnCategory.FlatAppearance.BorderSize = 0;
			this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategory.ForeColor = System.Drawing.Color.White;
			this.btnCategory.Location = new System.Drawing.Point(25, 17);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(148, 46);
			this.btnCategory.TabIndex = 0;
			this.btnCategory.Text = "Category";
			this.btnCategory.UseVisualStyleBackColor = false;
			this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnLogout.Location = new System.Drawing.Point(25, 381);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(148, 46);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Log out";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnExpenses
			// 
			this.btnExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnExpenses.FlatAppearance.BorderSize = 0;
			this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExpenses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExpenses.ForeColor = System.Drawing.Color.White;
			this.btnExpenses.Location = new System.Drawing.Point(25, 173);
			this.btnExpenses.Name = "btnExpenses";
			this.btnExpenses.Size = new System.Drawing.Size(148, 46);
			this.btnExpenses.TabIndex = 2;
			this.btnExpenses.Text = "Expenses";
			this.btnExpenses.UseVisualStyleBackColor = false;
			this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
			// 
			// btnBankProcesses
			// 
			this.btnBankProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnBankProcesses.FlatAppearance.BorderSize = 0;
			this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankProcesses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
			this.btnBankProcesses.Location = new System.Drawing.Point(25, 225);
			this.btnBankProcesses.Name = "btnBankProcesses";
			this.btnBankProcesses.Size = new System.Drawing.Size(148, 46);
			this.btnBankProcesses.TabIndex = 3;
			this.btnBankProcesses.Text = " Bank Processes";
			this.btnBankProcesses.UseVisualStyleBackColor = false;
			this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
			this.btnDashboard.FlatAppearance.BorderSize = 0;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.Location = new System.Drawing.Point(25, 277);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(148, 46);
			this.btnDashboard.TabIndex = 4;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.UseVisualStyleBackColor = false;
			// 
			// btnBills
			// 
			this.btnBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnBills.FlatAppearance.BorderSize = 0;
			this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBills.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBills.ForeColor = System.Drawing.Color.White;
			this.btnBills.Location = new System.Drawing.Point(25, 121);
			this.btnBills.Name = "btnBills";
			this.btnBills.Size = new System.Drawing.Size(148, 46);
			this.btnBills.TabIndex = 5;
			this.btnBills.Text = "Bills";
			this.btnBills.UseVisualStyleBackColor = false;
			this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
			// 
			// btnBanks
			// 
			this.btnBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnBanks.FlatAppearance.BorderSize = 0;
			this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanks.ForeColor = System.Drawing.Color.White;
			this.btnBanks.Location = new System.Drawing.Point(25, 69);
			this.btnBanks.Name = "btnBanks";
			this.btnBanks.Size = new System.Drawing.Size(148, 46);
			this.btnBanks.TabIndex = 6;
			this.btnBanks.Text = "Banks";
			this.btnBanks.UseVisualStyleBackColor = false;
			this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSettings.ForeColor = System.Drawing.Color.White;
			this.btnSettings.Location = new System.Drawing.Point(25, 329);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(148, 46);
			this.btnSettings.TabIndex = 7;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.btnSettings);
			this.panel1.Controls.Add(this.btnBanks);
			this.panel1.Controls.Add(this.btnBills);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBankProcesses);
			this.panel1.Controls.Add(this.btnExpenses);
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.btnCategory);
			this.panel1.Location = new System.Drawing.Point(-1, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 439);
			this.panel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dashboard Form";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(866, 34);
			this.panel2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.Silver;
			this.label2.Location = new System.Drawing.Point(15, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total Balance";
			// 
			// lblTotalBalance
			// 
			this.lblTotalBalance.AutoSize = true;
			this.lblTotalBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.lblTotalBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
			this.lblTotalBalance.Location = new System.Drawing.Point(32, 48);
			this.lblTotalBalance.Name = "lblTotalBalance";
			this.lblTotalBalance.Size = new System.Drawing.Size(84, 32);
			this.lblTotalBalance.TabIndex = 4;
			this.lblTotalBalance.Text = "0,00 ₺";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel3.Controls.Add(this.lblTotalBalance);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(221, 51);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(206, 112);
			this.panel3.TabIndex = 9;
			// 
			// lblBillTitle
			// 
			this.lblBillTitle.AutoSize = true;
			this.lblBillTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.lblBillTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblBillTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillTitle.ForeColor = System.Drawing.Color.Silver;
			this.lblBillTitle.Location = new System.Drawing.Point(15, 15);
			this.lblBillTitle.Name = "lblBillTitle";
			this.lblBillTitle.Size = new System.Drawing.Size(94, 20);
			this.lblBillTitle.TabIndex = 3;
			this.lblBillTitle.Text = "Invoice Title";
			// 
			// lblBillAmount
			// 
			this.lblBillAmount.AutoSize = true;
			this.lblBillAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.lblBillAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
			this.lblBillAmount.Location = new System.Drawing.Point(25, 48);
			this.lblBillAmount.Name = "lblBillAmount";
			this.lblBillAmount.Size = new System.Drawing.Size(84, 32);
			this.lblBillAmount.TabIndex = 4;
			this.lblBillAmount.Text = "0,00 ₺";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel4.Controls.Add(this.lblBillAmount);
			this.panel4.Controls.Add(this.lblBillTitle);
			this.panel4.Location = new System.Drawing.Point(433, 51);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(206, 112);
			this.panel4.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.Silver;
			this.label7.Location = new System.Drawing.Point(15, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(170, 20);
			this.label7.TabIndex = 3;
			this.label7.Text = "Last Incoming Transfer";
			// 
			// lblLastBankProcessAmount
			// 
			this.lblLastBankProcessAmount.AutoSize = true;
			this.lblLastBankProcessAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.lblLastBankProcessAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
			this.lblLastBankProcessAmount.Location = new System.Drawing.Point(37, 48);
			this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
			this.lblLastBankProcessAmount.Size = new System.Drawing.Size(84, 32);
			this.lblLastBankProcessAmount.TabIndex = 4;
			this.lblLastBankProcessAmount.Text = "0,00 ₺";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel5.Controls.Add(this.lblLastBankProcessAmount);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Location = new System.Drawing.Point(646, 51);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(206, 112);
			this.panel5.TabIndex = 10;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea7.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea7);
			legend7.Name = "Legend1";
			this.chart1.Legends.Add(legend7);
			this.chart1.Location = new System.Drawing.Point(221, 222);
			this.chart1.Name = "chart1";
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series7.Legend = "Legend1";
			series7.Name = "Banks";
			this.chart1.Series.Add(series7);
			this.chart1.Size = new System.Drawing.Size(300, 230);
			this.chart1.TabIndex = 12;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea8.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea8);
			legend8.Name = "Legend1";
			this.chart2.Legends.Add(legend8);
			this.chart2.Location = new System.Drawing.Point(542, 222);
			this.chart2.Name = "chart2";
			series8.ChartArea = "ChartArea1";
			series8.Legend = "Legend1";
			series8.Name = "Bills";
			this.chart2.Series.Add(series8);
			this.chart2.Size = new System.Drawing.Size(300, 230);
			this.chart2.TabIndex = 13;
			this.chart2.Text = "chart2";
			// 
			// FrmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(865, 473);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmDashboard";
			this.Load += new System.EventHandler(this.FrmDashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCategory;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnExpenses;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotalBalance;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblBillTitle;
		private System.Windows.Forms.Label lblBillAmount;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblLastBankProcessAmount;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
	}
}