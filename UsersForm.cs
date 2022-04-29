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
    public partial class UsersForm : Form
    {
        static string connectionString = @"Data Source= DESKTOP-EQH7H9H\SQLEXPRESS; Initial catalog=Курсовик (Мебельный); Integrated Security=True";
        SqlConnection MainCon = new SqlConnection(connectionString);
        bool work = false;
        Welcome goBack;
        int globalID;
        public UsersForm(Welcome gb, string name, int id)
        {
            InitializeComponent();

            goBack = gb;
            this.Text += name;

            globalID = id;

            SetStaffDGV();
            SetSalesDGV();
            SetClientsDGV();
            SetDelivDGV();
            SetMaterialsDGV();
        }
        public bool ChangePassCmd(string oldpass, string newpass)
        {
            string proverka = "select count(*) from Сотрудники where id = " + globalID + " and Пароль = hashbytes('MD5', Convert(varchar(max), @oldpassHash))";
            SqlCommand prov = new SqlCommand(proverka, MainCon);
            SqlParameter oldp = new SqlParameter("@oldpassHash", oldpass);
            prov.Parameters.Add(oldp);

            MainCon.Open();

            if (Convert.ToInt32(prov.ExecuteScalar()) == 1)
            {
                string chpass = "update Сотрудники set Пароль = hashbytes('MD5', Convert(varchar(max), @newpassHash)) where id = " + globalID;
                SqlCommand ch = new SqlCommand(chpass, MainCon);
                SqlParameter newp = new SqlParameter("@newpassHash", newpass);
                ch.Parameters.Add(newp);
                ch.ExecuteNonQuery();

                MainCon.Close();
                return true;
            }
            else
            {
                MainCon.Close();
                return false;
            }
        }

        private void SetStaffDGV()
        {
            MainCon.Open();
            string getStaff = "select ФИО, Должность from Сотрудники";
            SqlDataAdapter staff = new SqlDataAdapter(getStaff, MainCon);
            DataSet ds = new DataSet();
            staff.Fill(ds, "Сотрудники");

            StaffDGV.DataSource = ds.Tables["Сотрудники"];

            MainCon.Close();
        }
        private void SetSalesDGV()
        {
            MainCon.Open();
            string getSales = "select [Код продажи], [Артикул товара], Продажи.[Номер договора], [Дата договора], [Количество], [Цена продажи]  from Продажи inner join Договора on (Продажи.[Номер договора] = Договора.[Номер договора]) where Сотрудник = " + globalID;
            SqlDataAdapter sales = new SqlDataAdapter(getSales, MainCon);
            DataSet ds = new DataSet();
            sales.Fill(ds, "Продажи");

            SalesDGV.DataSource = ds.Tables["Продажи"];

            MainCon.Close();
        }
        private void SetClientsDGV()
        {
            MainCon.Open();
            string request = "select [ФИО/Организация], Контакты, [Постоянный клиент] from Клиенты inner join Договора on (Клиенты.id = Договора.Клиент) where Сотрудник = " + globalID;
            SqlDataAdapter adapter = new SqlDataAdapter(request, MainCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Клиенты");

            ClientsDGV.DataSource = ds.Tables["Клиенты"];

            MainCon.Close();
        }
        private void SetDelivDGV()
        {
            MainCon.Open();
            string request = "select [id доставки] as [Код доставки], [Адрес доставки], Сборка, [Дата доставки], Стоимость from Доставка where Сотрудник = " + globalID;
            SqlDataAdapter adapter = new SqlDataAdapter(request, MainCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Доставки");

            DelivDGV.DataSource = ds.Tables["Доставки"];

            MainCon.Close();
        }
        private void SetMaterialsDGV()
        {
            MainCon.Open();
            string request = "select [Вид материала], Наименование from Материалы";
            SqlDataAdapter adapter = new SqlDataAdapter(request, MainCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Материалы");

            MaterialsDGV.DataSource = ds.Tables["Материалы"];

            MainCon.Close();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (work == false)
                Application.Exit();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            work = true;
            goBack.Show();
            this.Close();
        }

        private void PrivRoomB_Click(object sender, EventArgs e)
        {
            //string data = "select ФИО, Должность, Телефон, Оклад, Образование from Сотрудники where id = " + globalID;
            string data = "select ФИО from Сотрудники where id = " + globalID;
            MainCon.Open();
            SqlCommand datacmd = new SqlCommand(data, MainCon);
            string name = datacmd.ExecuteScalar().ToString();

            data = "select Должность from Сотрудники where id = " + globalID;
            datacmd.CommandText = data;
            string pos = datacmd.ExecuteScalar().ToString();

            data = "select Телефон from Сотрудники where id = " + globalID;
            datacmd.CommandText = data;
            string phone = datacmd.ExecuteScalar().ToString();

            data = "select Оклад from Сотрудники where id = " + globalID;
            datacmd.CommandText = data;
            string salary = datacmd.ExecuteScalar().ToString();

            data = "select Образование from Сотрудники where id = " + globalID;
            datacmd.CommandText = data;
            string ed = datacmd.ExecuteScalar().ToString();

            data = "select Логин from Сотрудники where id = " + globalID;
            datacmd.CommandText = data;
            string log = datacmd.ExecuteScalar().ToString();

            MainCon.Close();

            PrivRoom myRoom = new PrivRoom(this, name, pos, phone, ed, salary, log);
            myRoom.Show();
            this.Enabled = false;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            this.betterFurnitureTableAdapter.Fill(this._Курсовик__Мебельный_DataSet4.BetterFurniture);
            //this.материалыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet4.Материалы);
        }

        private void RefreshTabB_Click(object sender, EventArgs e)
        {
            this.betterFurnitureTableAdapter.Fill(this._Курсовик__Мебельный_DataSet4.BetterFurniture);
            //this.материалыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet4.Материалы);
            SetStaffDGV();
            SetSalesDGV();
            SetClientsDGV();
            SetDelivDGV();
            SetMaterialsDGV();
        }
    }
}
