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
	public partial class FrmBanks : Form
	{
		public FrmBanks()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBanks_Load(object sender, EventArgs e)
		{
			//Bank Balance
			var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(x => x.BankBalance).FirstOrDefault();
			var albarakaBankBalance = db.Banks.Where(x => x.BankTitle == "Albaraka Bankası").Select(x => x.BankBalance).FirstOrDefault();
			var işBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(x => x.BankBalance).FirstOrDefault();
			lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
			lblAlbarakaBankBalance.Text = albarakaBankBalance.ToString() + " ₺";
			lblİşBankBalance.Text = işBankBalance.ToString() + " ₺";

			//Bank Processes
			var bankProcesses1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
			lblBankProcess1.Text = bankProcesses1.Description + " - " + bankProcesses1.Amount + " - " + bankProcesses1.ProcessDate;
			var bankProcesses2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
			lblBankProcess2.Text = bankProcesses2.Description + " - " + bankProcesses2.Amount + " - " + bankProcesses2.ProcessDate;
			var bankProcesses3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
			lblBankProcess3.Text = bankProcesses3.Description + " - " + bankProcesses3.Amount + " - " + bankProcesses3.ProcessDate;
			var bankProcesses4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
			lblBankProcess4.Text = bankProcesses4.Description + " - " + bankProcesses4.Amount + " - " + bankProcesses4.ProcessDate;
			var bankProcesses5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
			lblBankProcess5.Text = bankProcesses5.Description + " - " + bankProcesses5.Amount + " - " + bankProcesses5.ProcessDate;
		}
		private void btnBills_Click(object sender, EventArgs e)
		{
			FormLink.BillsLink();
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
