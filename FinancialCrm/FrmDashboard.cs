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
	public partial class FrmDashboard : Form
	{
		public FrmDashboard()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		int count = 0;
		private void FrmDashboard_Load(object sender, EventArgs e)
		{
			var totalBalance = db.Banks.Sum(x => x.BankBalance);
			lblTotalBalance.Text = totalBalance.ToString() + " ₺";

			var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
			lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

			//chart 1 codes
			var BankData = db.Banks.Select(x=> new { x.BankTitle, x.BankBalance }).ToList();
			chart1.Series.Clear();
			var series = chart1.Series.Add("Banks");
			series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			foreach (var item in BankData)
			{
				int index =series.Points.AddXY(item.BankTitle, item.BankBalance);
				series.Points[index].LegendText = item.BankTitle;
				series.Points[index].Label = " ";
			}

			//chart 2 codes
			var BillData = db.Bills.Select(x => new { x.BillTitle, x.BillAmount }).ToList();
			chart2.Series.Clear();
			var series2 = chart2.Series.Add("Bills");
			foreach (var item in BillData)
			{
				series2.Points.AddXY(item.BillTitle, item.BillAmount);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count ++;
			switch (count)
			{
				case 1:
					var bill1 = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
					lblBillTitle.Text = "Su Faturası";
					lblBillAmount.Text = bill1.ToString() + " ₺";
					break;
				case 2:
					var bill2 = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
					lblBillTitle.Text = "Elektrik Faturası";
					lblBillAmount.Text = bill2.ToString() + " ₺";
					break;
				case 3:
					var bill3 = db.Bills.Where(x => x.BillTitle == "Anizium Faturası").Select(y => y.BillAmount).FirstOrDefault();
					lblBillTitle.Text = "Anizium Faturası";
					lblBillAmount.Text = bill3.ToString() + " ₺";
					break;
				case 4:
					var bill4 = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
					lblBillTitle.Text = "İnternet Faturası";
					lblBillAmount.Text = bill4.ToString() + " ₺";
					break;
				case 5:
					var bill5 = db.Bills.Where(x => x.BillTitle == "Yurt Faturası").Select(y => y.BillAmount).FirstOrDefault();
					lblBillTitle.Text = "Yurt Faturası";
					lblBillAmount.Text = bill5.ToString() + " ₺";
					count = 0;
					break;
				default:
					break;
			}
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
