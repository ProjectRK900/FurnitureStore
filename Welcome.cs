using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFRKCurs
{
    public partial class Welcome : Form
    {
        static string connectionString = @"Data Source= *deleted*; Initial catalog=*deleted*; Integrated Security=True";
        SqlConnection MainCon = new SqlConnection(connectionString);
        public Welcome()
        {
            InitializeComponent();
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            string FindCom = "select count(*) from Сотрудники where Логин = @log and Пароль = hashbytes('MD5', Convert(varchar(max), @passHash))";
            SqlCommand findcmd = new SqlCommand(FindCom, MainCon);
            SqlParameter log = new SqlParameter("@log", LogTB.Text);
            SqlParameter pass = new SqlParameter("@passHash", PassTB.Text);
            findcmd.Parameters.Add(log);
            findcmd.Parameters.Add(pass);

            MainCon.Open();
            
            if (Convert.ToInt32(findcmd.ExecuteScalar()) == 1)
            {
                ErrorL.Visible = false;

                string role = "select [Роль в БД] from Сотрудники where Логин = @log and Пароль = hashbytes('MD5', Convert(varchar(max), @passHash))";
                SqlCommand rolecmd = new SqlCommand(role, MainCon);
                SqlParameter log2 = new SqlParameter("@log", LogTB.Text);
                SqlParameter pass2 = new SqlParameter("@passHash", PassTB.Text);
                rolecmd.Parameters.Add(log2);
                rolecmd.Parameters.Add(pass2);

                string name = "select ФИО from Сотрудники where Логин = @log and Пароль = hashbytes('MD5', Convert(varchar(max), @passHash))";
                SqlCommand namecmd = new SqlCommand(name, MainCon);
                SqlParameter log3 = new SqlParameter("@log", LogTB.Text);
                SqlParameter pass3 = new SqlParameter("@passHash", PassTB.Text);
                namecmd.Parameters.Add(log3);
                namecmd.Parameters.Add(pass3);
                string idtravel = "select id from Сотрудники where Логин = @log";

                if (rolecmd.ExecuteScalar().ToString() == "admin")
                {
                    SqlCommand idcmdA = new SqlCommand(idtravel, MainCon);
                    SqlParameter log5 = new SqlParameter("@log", LogTB.Text);
                    idcmdA.Parameters.Add(log5);

                    AdminsForm newAF = new AdminsForm(this, namecmd.ExecuteScalar().ToString(), Convert.ToInt32(idcmdA.ExecuteScalar())); ;
                    this.Hide();
                    newAF.Show();

                    MainCon.Close();
                    LogTB.Text = "";
                    PassTB.Text = "";
                }
                else
                {
                    SqlCommand idcmd = new SqlCommand(idtravel, MainCon);
                    SqlParameter log4 = new SqlParameter("@log", LogTB.Text);
                    idcmd.Parameters.Add(log4);

                    UsersForm newUF = new UsersForm(this, namecmd.ExecuteScalar().ToString(), Convert.ToInt32(idcmd.ExecuteScalar()));
                    this.Hide();
                    newUF.Show();

                    MainCon.Close();
                    LogTB.Text = "";
                    PassTB.Text = "";
                }
            }
            else
                ErrorL.Visible = true;

            MainCon.Close();
        }
    }
}
