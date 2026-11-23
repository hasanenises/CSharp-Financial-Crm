namespace FinancialCrm
{
	partial class FrmExpenses
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnExpenses = new System.Windows.Forms.Button();
			this.btnCategory = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.dtpSpendingDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSpendingAmount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSpendingTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSpendingId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(866, 34);
			this.panel2.TabIndex = 11;
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
			this.label1.Size = new System.Drawing.Size(123, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Expenses Form";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.btnSettings);
			this.panel1.Controls.Add(this.btnBanks);
			this.panel1.Controls.Add(this.btnBills);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBankProcesses);
			this.panel1.Controls.Add(this.btnExpenses);
			this.panel1.Controls.Add(this.btnCategory);
			this.panel1.Location = new System.Drawing.Point(-1, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 439);
			this.panel1.TabIndex = 10;
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
			this.btnLogout.TabIndex = 8;
			this.btnLogout.Text = "Log out";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
			// btnDashboard
			// 
			this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
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
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
			// btnExpenses
			// 
			this.btnExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Location = new System.Drawing.Point(197, 248);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(668, 222);
			this.panel4.TabIndex = 9;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
			this.dataGridView1.Location = new System.Drawing.Point(3, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridView1.Size = new System.Drawing.Size(662, 214);
			this.dataGridView1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
			this.panel3.Controls.Add(this.cmbCategory);
			this.panel3.Controls.Add(this.dtpSpendingDate);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.btnDelete);
			this.panel3.Controls.Add(this.btnCreate);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.txtSpendingAmount);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txtSpendingTitle);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtSpendingId);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(197, 34);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(668, 213);
			this.panel3.TabIndex = 8;
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(130, 136);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(158, 21);
			this.cmbCategory.TabIndex = 14;
			// 
			// dtpSpendingDate
			// 
			this.dtpSpendingDate.Location = new System.Drawing.Point(130, 105);
			this.dtpSpendingDate.Name = "dtpSpendingDate";
			this.dtpSpendingDate.Size = new System.Drawing.Size(158, 20);
			this.dtpSpendingDate.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(60, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Category:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(442, 172);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(118, 36);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(283, 172);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(118, 36);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(124, 172);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(118, 36);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(27, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Spending Date:";
			// 
			// txtSpendingAmount
			// 
			this.txtSpendingAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
			this.txtSpendingAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSpendingAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingAmount.ForeColor = System.Drawing.Color.White;
			this.txtSpendingAmount.Location = new System.Drawing.Point(130, 76);
			this.txtSpendingAmount.Name = "txtSpendingAmount";
			this.txtSpendingAmount.Size = new System.Drawing.Size(514, 23);
			this.txtSpendingAmount.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(9, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Spending Amount:";
			// 
			// txtSpendingTitle
			// 
			this.txtSpendingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
			this.txtSpendingTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSpendingTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingTitle.ForeColor = System.Drawing.Color.White;
			this.txtSpendingTitle.Location = new System.Drawing.Point(130, 47);
			this.txtSpendingTitle.Name = "txtSpendingTitle";
			this.txtSpendingTitle.Size = new System.Drawing.Size(514, 23);
			this.txtSpendingTitle.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(30, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Spending Title:";
			// 
			// txtSpendingId
			// 
			this.txtSpendingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
			this.txtSpendingId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSpendingId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingId.ForeColor = System.Drawing.Color.White;
			this.txtSpendingId.Location = new System.Drawing.Point(130, 18);
			this.txtSpendingId.Name = "txtSpendingId";
			this.txtSpendingId.Size = new System.Drawing.Size(514, 23);
			this.txtSpendingId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(43, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Spending Id:";
			// 
			// FrmExpenses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(865, 473);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmExpenses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmExpenses";
			this.Load += new System.EventHandler(this.FrmExpenses_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnExpenses;
		private System.Windows.Forms.Button btnCategory;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSpendingAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSpendingTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSpendingId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.DateTimePicker dtpSpendingDate;
		private System.Windows.Forms.Label label6;
	}
}