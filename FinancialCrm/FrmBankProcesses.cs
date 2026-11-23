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
	public partial class FrmBankProcesses : Form
	{
		public FrmBankProcesses()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		void BankProcessList()
		{
			var values = db.BankProcesses
				.Select(x => new
				{
					x.BankProcessId,
					x.Description,
					x.ProcessType,
					x.Amount,
					x.ProcessDate,
					BankTitle = x.Banks.BankTitle
				}).ToList();

			dataGridView1.DataSource = values;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		void BankFill()
		{
			var banks = db.Banks.ToList();
			cmbBank.DisplayMember = "BankTitle";
			cmbBank.ValueMember = "BankId";
			cmbBank.DataSource = banks;
		}
		private void FrmBankProcesses_Load(object sender, EventArgs e)
		{
			cmbProcessType.SelectedIndex = 0;
			BankFill();
			BankProcessList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			int bankId = int.Parse(cmbBank.SelectedValue.ToString());
			decimal amount = decimal.Parse(txtAmount.Text);
			string processType = cmbProcessType.Text.Trim();

			var bank = db.Banks.Find(bankId);
			if (bank == null)
			{
				MessageBox.Show("Banka bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (processType == "Giden Havale" || processType == "Çekme")
			{
				if (bank.BankBalance < amount)
				{
					MessageBox.Show("Banka bakiyesi yetersiz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				bank.BankBalance -= amount;
			}
			else if (processType == "Gelen Havale" || processType == "Yatırma")
			{
				bank.BankBalance += amount;
			}

			BankProcesses process = new BankProcesses();
			process.Description = txtDescription.Text;
			process.ProcessType = processType;
			process.Amount = amount;
			process.ProcessDate = dtpProcessDate.Value;
			process.BankId = bankId;

			db.BankProcesses.Add(process);
			db.SaveChanges();

			MessageBox.Show("İşlem kaydedildi ve banka bakiyesi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			BankProcessList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProcessId.Text);
			var value = db.BankProcesses.Find(id);
			db.BankProcesses.Remove(value);
			db.SaveChanges();
			MessageBox.Show("Banka işlemi silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			BankProcessList();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProcessId.Text);
			var value = db.BankProcesses.Find(id);
			value.Description = txtDescription.Text;
			value.ProcessType = cmbProcessType.Text;
			value.Amount = decimal.Parse(txtAmount.Text);
			value.ProcessDate = dtpProcessDate.Value;
			value.BankId = int.Parse(cmbBank.SelectedValue.ToString());

			db.SaveChanges();
			MessageBox.Show("Banka işlemi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			BankProcessList();
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

		private void btnExpenses_Click(object sender, EventArgs e)
		{
			FormLink.ExpensesLink();
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
