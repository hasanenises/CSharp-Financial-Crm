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
	public partial class FrmSettings : Form
	{
		public FrmSettings()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		void UserList()
		{
			var values = db.Users
				.Select(x => new
				{
					x.UserId,
					x.UserName,
					x.Password
				}).ToList();

			dataGridView1.DataSource = values;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
		private void FrmSettings_Load(object sender, EventArgs e)
		{
			UserList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Users user = new Users();
			user.UserName = txtUserName.Text;
			user.Password = txtPassword.Text;

			db.Users.Add(user);
			db.SaveChanges();
			MessageBox.Show("Kullanıcı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UserList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtUserId.Text);
			var value = db.Users.Find(id);
			db.Users.Remove(value);
			db.SaveChanges();
			MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			UserList();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtUserId.Text);
			var value = db.Users.Find(id);
			value.UserName = txtUserName.Text;
			value.Password = txtPassword.Text;

			db.SaveChanges();
			MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			UserList();
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

		private void btnLogout_Click(object sender, EventArgs e)
		{
			FormLink.LogoutLink();
		}
	}
}
