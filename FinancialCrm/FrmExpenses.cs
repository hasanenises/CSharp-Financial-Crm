using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
	public partial class FrmExpenses : Form
	{
		public FrmExpenses()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		void Spendinglist()
		{
			var values = db.Spendings
				.Select(x => new
				{
					x.SpendingId,
					x.SpendingTitle,
					x.SpendingAmount,
					x.SpendingDate,
					CategoryName = x.Categories.CategoryName
				}).ToList();

			dataGridView1.DataSource = values;	
		}

		void CategoryFill()
		{
			var categories = db.Categories.ToList();
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryId";
			cmbCategory.DataSource = categories;
		}

		private void FrmExpenses_Load(object sender, EventArgs e)
		{
			Spendinglist();
			CategoryFill();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Spendings spending = new Spendings();
			spending.SpendingTitle = txtSpendingTitle.Text;
			spending.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
			spending.SpendingDate = dtpSpendingDate.Value;
			spending.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());

			db.Spendings.Add(spending);
			db.SaveChanges();
			MessageBox.Show("Gider başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Spendinglist();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txtSpendingId.Text);
			var values = db.Spendings.Find(Id);
			db.Spendings.Remove(values);
			db.SaveChanges();
			MessageBox.Show("Gider başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Spendinglist();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txtSpendingId.Text);
			var values = db.Spendings.Find(Id);
			values.SpendingTitle = txtSpendingTitle.Text;
			values.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
			values.SpendingDate = dtpSpendingDate.Value;
			values.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Gider başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Spendinglist();
		}
		private void btnCategory_Click(object sender, EventArgs e)
		{
			FormLink.CategoryLink();
			this.Hide();
		}

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FormLink.BanksLink();
			this.Hide();
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			FormLink.BillsLink();
			this.Hide();
		}

		private void btnBankProcesses_Click(object sender, EventArgs e)
		{
			FormLink.BankProcessesLink();
			this.Hide();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FormLink.DashboardLink();
			this.Hide();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			FormLink.SettingsLink();
			this.Hide();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			FormLink.LogoutLink();
		}
	}
}
