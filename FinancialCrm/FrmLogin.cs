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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void btnLogin_Click(object sender, EventArgs e)
		{
			var user = db.Users.FirstOrDefault(x => x.UserName == 
			txtUserName.Text && x.Password == txtPassword.Text);
			if (user != null)
			{
				FormLink.DashboardLink();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
			}
		}
	}
}
