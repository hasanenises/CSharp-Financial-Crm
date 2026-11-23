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
	public partial class FrmBills : Form
	{
		public FrmBills()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBiils_Load(object sender, EventArgs e)
		{
			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			string Title = txtTitle.Text;
			decimal Amount = Convert.ToDecimal(txtAmount.Text);
			string period = txtPeriod.Text;

			Bills bills = new Bills();
			bills.BillTitle = Title;
			bills.BillAmount = Amount;
			bills.BillPeriod = period;
			db.Bills.Add(bills);
			db.SaveChanges();
			MessageBox.Show("Bill Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			FrmBiils_Load(null, null);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtBillId.Text);
			var values = db.Bills.Find(id);
			db.Bills.Remove(values);
			db.SaveChanges();
			MessageBox.Show("Bill Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			FrmBiils_Load(null, null);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string Title = txtTitle.Text;
			decimal Amount = Convert.ToDecimal(txtAmount.Text);
			string period = txtPeriod.Text;
			int id = Convert.ToInt32(txtBillId.Text);

			var values = db.Bills.Find(id);

			values.BillTitle = Title;
			values.BillAmount = Amount;
			values.BillPeriod = period;
			db.SaveChanges();
			MessageBox.Show("Bill Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			FrmBiils_Load(null, null);
		}
		private void btnBanks_Click(object sender, EventArgs e)
		{
			FormLink.BanksLink();
			this.Hide();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FormLink.DashboardLink();
			this.Hide();
		}		

		private void btnCategory_Click(object sender, EventArgs e)
		{
			FormLink.CategoryLink();
			this.Hide();
		}

		private void btnExpenses_Click(object sender, EventArgs e)
		{
			FormLink.ExpensesLink();
			this.Hide();
		}

		private void btnBankProcesses_Click(object sender, EventArgs e)
		{
			FormLink.BankProcessesLink();
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
