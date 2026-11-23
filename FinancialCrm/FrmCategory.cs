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
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		void CategoryList()
		{
			var categories = db.Categories.Select(x => new { x.CategoryId, x.CategoryName }).ToList();
			dataGridView1.DataSource = categories;
		}	

		private void FrmCategory_Load(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var category = new Categories();
			category.CategoryName = txtCategoryName.Text;
			db.Categories.Add(category);
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CategoryList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var value = db.Categories.Find(id);
			db.Categories.Remove(value);
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CategoryList();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var value = db.Categories.Find(id);
			value.CategoryName = txtCategoryName.Text;
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CategoryList();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCategoryId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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
