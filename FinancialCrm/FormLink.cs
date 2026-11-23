using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
	public static class FormLink
	{
		public static void CategoryLink()
		{
			FrmCategory frmCategory = new FrmCategory();
			frmCategory.Show();
		}
		public static void BanksLink()
		{
			FrmBanks frmBanks = new FrmBanks();
			frmBanks.Show();
		}

		public static void BillsLink()
		{
			FrmBills frmBills = new FrmBills();
			frmBills.Show();
		}

		public static void ExpensesLink()
		{
			FrmExpenses frmExpenses = new FrmExpenses();
			frmExpenses.Show();
		}

		public static void BankProcessesLink()
		{
			FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
			frmBankProcesses.Show();
		}

		public static void DashboardLink()
		{
			FrmDashboard frmDashboard = new FrmDashboard();
			frmDashboard.Show();
		}

		public static void SettingsLink()
		{
			FrmSettings frmSettings = new FrmSettings();
			frmSettings.Show();
		}

		public static void LogoutLink()
		{
			DialogResult result = MessageBox.Show(
			"Are you sure you want to log out?",
			"Log Out",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
