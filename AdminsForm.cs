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
    public partial class AdminsForm : Form
    {
        string constClient = "N'Нет'", assembly = "N'Нет'";
        static string connectionString = @"Data Source= DESKTOP-EQH7H9H\SQLEXPRESS; Initial catalog=Курсовик (Мебельный); Integrated Security=True";
        SqlConnection MainCon = new SqlConnection(connectionString);
        bool work = false;
        Welcome goBack;
        int globalID;
        public AdminsForm(Welcome gb, string name, int id)
        {
            InitializeComponent();

            globalID = id;

            goBack = gb;
            this.Text += name;

            CModeCB.SelectedIndex = 0;
            ConModeCB.SelectedIndex = 0;
            DModeCB.SelectedIndex = 0;
            SModeCB.SelectedIndex = 0;
        }

        private void AdminsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void DelB_Click(object sender, EventArgs e)
        {
            if (idMTB.Text != "" && Convert.ToInt32(idMTB.Text) != globalID)
            {
                MainCon.Open();
                string exist = "select count(*) from Сотрудники where id = " + idMTB.Text;
                SqlCommand excmd = new SqlCommand(exist, MainCon);
                if (Convert.ToInt32(excmd.ExecuteScalar()) == 1)
                {
                    string WhatRole = "select [Роль в БД] from Сотрудники where id = " + idMTB.Text;
                    SqlCommand wr = new SqlCommand(WhatRole, MainCon);
                    if (wr.ExecuteScalar().ToString() != "admin")
                    {
                        ErrorStaffL.Visible = false;
                        string DelFromDB = "delete from Сотрудники where id = " + idMTB.Text;
                        SqlCommand Del = new SqlCommand(DelFromDB, MainCon);
                        Del.ExecuteNonQuery();
                        MainCon.Close();

                        RefreshTab();
                        SuccessL.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    else
                        ErrorStaffL.Visible = true;
                }
                else
                    ErrorStaffL.Visible = true;
            }
            else
                ErrorStaffL.Visible = true;
        }

        public void UpdateCmd(int id, string name, string position, string phone, string salary, string ed, string role, string log, string pass)
        {
            MainCon.Open();
            string UpIntoDB = "update Сотрудники set ФИО = @name, Должность = @pos, Телефон = '" + phone + "', Оклад = '" + salary + "', Образование = N'" + ed + "', [Роль в БД] = '" + role + "', Логин = @log, Пароль = hashbytes('MD5', Convert(varchar(max), @pass)) where id = " + id;
            SqlCommand Up = new SqlCommand(UpIntoDB, MainCon);
            SqlParameter upname = new SqlParameter("@name", name);
            Up.Parameters.Add(upname);
            SqlParameter uppos = new SqlParameter("@pos", position);
            Up.Parameters.Add(uppos);
            SqlParameter uplog = new SqlParameter("@log", log);
            Up.Parameters.Add(uplog);
            SqlParameter uppass = new SqlParameter("@pass", pass);
            Up.Parameters.Add(uppass);

            MainCon.Open();
            Up.ExecuteNonQuery();
            MainCon.Close();

            RefreshTab();
            SuccessL.Visible = true;
            TimerOfSuccess.Enabled = true;
            ErrorStaffL.Visible = false;
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            MainCon.Open();
            string exist = "select count(*) from Сотрудники where id = " + idMTB.Text;
            SqlCommand excmd = new SqlCommand(exist, MainCon);
            if (idMTB.Text != "" && Convert.ToInt32(idMTB.Text) != globalID && Convert.ToInt32(excmd.ExecuteScalar()) == 1)
            {
                string WhatRole = "select [Роль в БД] from Сотрудники where id = " + idMTB.Text;
                SqlCommand wr = new SqlCommand(WhatRole, MainCon);
                if (wr.ExecuteScalar().ToString() != "admin")
                {
                    ErrorStaffL.Visible = false;
                    UpdateStaff uS = new UpdateStaff(Convert.ToInt32(idMTB.Text), this);
                    this.Enabled = false;
                    uS.Show();
                    MainCon.Close();
                }
                else
                    ErrorStaffL.Visible = true;
            }
            else
                ErrorStaffL.Visible = true;
            MainCon.Close();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            NewInStaff nS = new NewInStaff(this);
            this.Enabled = false;
            nS.Show();
        }
        public void AddCmdStaff(string name, string position, string phone, string salary, string ed, string role, string log, string pass)
        {
            string AddIntoDB = "insert into Сотрудники values (@name, @position, '" + phone + "', '" + salary + "', N'" + ed + "', '" + role + "', @log, hashbytes('MD5', Convert(varchar(max), @pass)))";
            //AddIntoDB = "insert into Сотрудники values (@name, @position, '" + phone + "', '" + salary + "', N'" + ed + "', '" + role + "', @log, hashbytes('MD5', Convert(varchar(max), @pass)))";
            SqlCommand AddStaff = new SqlCommand(AddIntoDB, MainCon);
            SqlParameter adname = new SqlParameter("@name", name);
            AddStaff.Parameters.Add(adname);
            SqlParameter adpos = new SqlParameter("@position", position);
            AddStaff.Parameters.Add(adpos);
            SqlParameter adlog = new SqlParameter("@log", log);
            AddStaff.Parameters.Add(adlog);
            SqlParameter adpass = new SqlParameter("@pass", pass);
            AddStaff.Parameters.Add(adpass);

            MainCon.Open();
            AddStaff.ExecuteNonQuery();
            MainCon.Close();

            RefreshTab();
            SuccessL.Visible = true;
            TimerOfSuccess.Enabled = true;
            ErrorStaffL.Visible = false;
        }

        private void TimerOfSuccess_Tick(object sender, EventArgs e)
        {
            if (AllTablesTC.SelectedIndex == 0) // Сотрудники
            {
                SuccessL.Visible = false;
                TimerOfSuccess.Enabled = false;
            }
            if (AllTablesTC.SelectedIndex == 1) // Клиенты
            {
                Success1L.Visible = false;
                TimerOfSuccess.Enabled = false;
            }
            if (AllTablesTC.SelectedIndex == 2) // Договора
            {
                ConErrorL.Visible = false;
                Success2L.Visible = false;
                TimerOfSuccess.Enabled = false;
            }
            if (AllTablesTC.SelectedIndex == 3) // Доставка
            {
                DErrorL.Visible = false;
                Success3L.Visible = false;
                TimerOfSuccess.Enabled = false;
            }
            if (AllTablesTC.SelectedIndex == 4) // Продажи
            {
                Error4L.Visible = false;
                Success4L.Visible = false;
                TimerOfSuccess.Enabled = false;
            }
            if (AllTablesTC.SelectedIndex == 5) // Мебель
            {
                Error5L.Visible = false;
                Success5L.Visible = false;
                TimerOfSuccess.Enabled = false;
            }
            //if (AllTablesTC.SelectedIndex == 6) // Материалы
            //{
                
            //}
        }

        private void AdminsForm_Load(object sender, EventArgs e)
        {
            this.продажиTableAdapter1.Fill(this._Курсовик__Мебельный_DataSet3.Продажи);
            this.staffWithoutPassTableAdapter.Fill(this._Курсовик__Мебельный_DataSet.StaffWithoutPass);
            this.клиентыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet1.Клиенты);
            this.betterContractsTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.BetterContracts);
            this.betterDeliveryTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.BetterDelivery);
            //this.продажиTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.Продажи);
            this.betterFurnitureTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.BetterFurniture);
            this.материалыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.Материалы);

            RefreshTab();
        }

        private void RefreshTab()
        {
            if (AllTablesTC.SelectedIndex == 0) // Сотрудники
            {
                this.staffWithoutPassTableAdapter.Fill(this._Курсовик__Мебельный_DataSet.StaffWithoutPass);
                StaffDGV.DataSource = staffWithoutPassBindingSource;
            }
            if (AllTablesTC.SelectedIndex == 1) // Клиенты
            {
                this.клиентыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet1.Клиенты);
                ClientsDGV.DataSource = клиентыBindingSource;
            }
            if (AllTablesTC.SelectedIndex == 2) // Договора
            {
                this.betterContractsTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.BetterContracts);
                ContractsDGV.DataSource = betterContractsBindingSource;
            }
            if (AllTablesTC.SelectedIndex == 3) // Доставка
            {
                this.betterDeliveryTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.BetterDelivery);
                DeliveryDGV.DataSource = betterDeliveryBindingSource;
            }
            if (AllTablesTC.SelectedIndex == 4) // Продажи
            {
                this.продажиTableAdapter1.Fill(this._Курсовик__Мебельный_DataSet3.Продажи);
                SalesDGV.DataSource = продажиBindingSource2;
            }
            if (AllTablesTC.SelectedIndex == 5) // Мебель
            {
                this.betterFurnitureTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.BetterFurniture);
                FurnitureDGV.DataSource = betterFurnitureBindingSource;
            }
            if (AllTablesTC.SelectedIndex == 6) // Материалы
            {
                this.материалыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.Материалы);
                MaterialsDGV.DataSource = материалыBindingSource;
            }
        }

        private void CModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CModeCB.SelectedIndex == 0)
            {
                CidMTB.Enabled = true;

                CNameTB.Enabled = false;
                CContactsTB.Enabled = false;
                CConstCheckB.Enabled = false;

            }
            else
            {
                if (CModeCB.SelectedIndex == 1)
                {
                    CidMTB.Enabled = false;

                    CNameTB.Enabled = true;
                    CContactsTB.Enabled = true;
                    CConstCheckB.Enabled = true;

                }
                else
                {
                    CidMTB.Enabled = true;

                    CNameTB.Enabled = true;
                    CContactsTB.Enabled = true;
                    CConstCheckB.Enabled = true;

                }
            }
        }

        private void CAddorUpdateB_Click(object sender, EventArgs e)
        {
            if (CModeCB.SelectedIndex == 1) // Добавление
            {
                string AddIntoDB = "insert into Клиенты values (@name, @contacts, " + constClient + ")";
                SqlCommand AddClient = new SqlCommand(AddIntoDB, MainCon);
                SqlParameter adname = new SqlParameter("@name", CNameTB.Text);
                AddClient.Parameters.Add(adname);
                SqlParameter adcon = new SqlParameter("@contacts", CContactsTB.Text);
                AddClient.Parameters.Add(adcon);

                MainCon.Open();
                AddClient.ExecuteNonQuery();
                MainCon.Close();
                RefreshTab();
                Success1L.Visible = true;
                TimerOfSuccess.Enabled = true;
            }

            if (CModeCB.SelectedIndex == 2) // Изменение
            {
                string UpdateDB = "update Клиенты set [ФИО/Организация] = @name, [Контакты] = @contacts, [Постоянный клиент] = " + constClient + " where id = " + CidMTB.Text;
                SqlCommand UpClient = new SqlCommand(UpdateDB, MainCon);
                SqlParameter upname = new SqlParameter("@name", CNameTB.Text);
                UpClient.Parameters.Add(upname);
                SqlParameter upcon = new SqlParameter("@contacts", CContactsTB.Text);
                UpClient.Parameters.Add(upcon);

                MainCon.Open();
                UpClient.ExecuteNonQuery();
                MainCon.Close();
                RefreshTab();
                Success1L.Visible = true;
                TimerOfSuccess.Enabled = true;
            }

            if (CModeCB.SelectedIndex == 0) // Удаление
            {
                string DelFromDB = "delete from Клиенты where id = " + CidMTB.Text;
                SqlCommand DelClient = new SqlCommand(DelFromDB, MainCon);

                MainCon.Open();
                DelClient.ExecuteNonQuery();
                MainCon.Close();
                RefreshTab();
                Success1L.Visible = true;
                TimerOfSuccess.Enabled = true;
            }
        }

        private void CConstCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (CConstCheckB.Checked == true)
                constClient = "N'Да'";
            else
                constClient = "N'Нет'";
        }

        private void AllTablesTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTab();
        }

        private void CDelB_Click(object sender, EventArgs e)
        {
            string DelFromDB = "delete from Клиенты where id = " + CidMTB.Text;
            SqlCommand DelClient = new SqlCommand(DelFromDB, MainCon);

            MainCon.Open();
            DelClient.ExecuteNonQuery();
            MainCon.Close();
            RefreshTab();
            Success1L.Visible = true;
            TimerOfSuccess.Enabled = true;
        }

        private void ConModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConModeCB.SelectedIndex == 0)
            {
                ConNumConMTB.Enabled = true;
                ConClientCB.Enabled = false;
                ConStaffCB.Enabled = false;
                ConNumDelCB.Enabled = false;
                ConDateMTB.Enabled = false;
                ConSumMTB.Enabled = false;

            }
            else
            {
                if (ConModeCB.SelectedIndex == 1)
                {
                    ConNumConMTB.Enabled = true;
                    ConClientCB.Enabled = true;
                    ConStaffCB.Enabled = true;
                    ConNumDelCB.Enabled = true;
                    ConDateMTB.Enabled = true;
                    ConSumMTB.Enabled = true;
                }
                else
                {
                    ConNumConMTB.Enabled = true;
                    ConClientCB.Enabled = true;
                    ConStaffCB.Enabled = true;
                    ConNumDelCB.Enabled = true;
                    ConDateMTB.Enabled = true;
                    ConSumMTB.Enabled = true;
                }
            }
        }

        private void ExecB_Click(object sender, EventArgs e)
        {
            if (ConModeCB.SelectedIndex == 0) // Удаление
            {
                string DelFromDB = "delete from Договора where [Номер договора] = " + ConNumConMTB.Text;
                SqlCommand DelContract = new SqlCommand(DelFromDB, MainCon);

                MainCon.Open();
                DelContract.ExecuteNonQuery();
                MainCon.Close();
                RefreshTab();
                Success2L.Visible = true;
                TimerOfSuccess.Enabled = true;
                ConErrorL.Visible = false;

            }
            else
            {
                if (ConModeCB.SelectedIndex == 1) // Добавление
                {
                    string AddIntoDB = "insert into Договора values (" + ConNumConMTB.Text + ", " + ConClientCB.SelectedValue + ", " + ConStaffCB.SelectedValue + ", " + ConNumDelCB.SelectedValue + ", '" + ConDateMTB.Text + "', " + ConSumMTB.Text + ")";
                    SqlCommand AddContract = new SqlCommand(AddIntoDB, MainCon);
                    try
                    {
                        MainCon.Open();
                        AddContract.ExecuteNonQuery();
                        MainCon.Close();
                        RefreshTab();
                        Success2L.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    catch
                    {
                        ConErrorL.Visible = true;
                    }
                }
                else // Изменение
                {
                    string UpdateDB = "update Договора set Клиент = " + ConClientCB.SelectedValue + ", Сотрудник = " + ConStaffCB.SelectedValue + ", [Номер доставки] = " + ConNumDelCB.SelectedValue + ", [Дата договора] = '" + ConDateMTB.Text + "', [Итоговая стоимость] = " + ConSumMTB.Text + " where [Номер договора] = " + ConNumConMTB.Text;
                    SqlCommand UpContract = new SqlCommand(UpdateDB, MainCon);
                    try
                    {
                        MainCon.Open();
                        UpContract.ExecuteNonQuery();
                        MainCon.Close();
                        RefreshTab();
                        Success2L.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    catch
                    {
                        ConErrorL.Visible = true;
                    }
                }
            }
        }

        private void DModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DModeCB.SelectedIndex == 0)
            {
                DidMTB.Enabled = true;
                DadresTB.Enabled = false;
                DassemblyCheckB.Enabled = false;
                DStaffCB.Enabled = false;
                DdateMTB.Enabled = false;
                DsumMTB.Enabled = false;
            }
            else
            {
                if (DModeCB.SelectedIndex == 1)
                {
                    DidMTB.Enabled = true;
                    DadresTB.Enabled = true;
                    DassemblyCheckB.Enabled = true;
                    DStaffCB.Enabled = true;
                    DdateMTB.Enabled = true;
                    DsumMTB.Enabled = true;

                }
                else
                {
                    DidMTB.Enabled = true;
                    DadresTB.Enabled = true;
                    DassemblyCheckB.Enabled = true;
                    DStaffCB.Enabled = true;
                    DdateMTB.Enabled = true;
                    DsumMTB.Enabled = true;

                }
            }
        }

        private void DexecB_Click(object sender, EventArgs e)
        {
            if (DModeCB.SelectedIndex == 0) // Удаление
            {
                string DelFromDB = "delete from Доставка where [id доставки] = " + DidMTB.Text;
                SqlCommand DelDeliv = new SqlCommand(DelFromDB, MainCon);

                MainCon.Open();
                DelDeliv.ExecuteNonQuery();
                MainCon.Close();
                RefreshTab();
                Success3L.Visible = true;
                TimerOfSuccess.Enabled = true;
                DErrorL.Visible = false;

            }
            else
            {
                if (DModeCB.SelectedIndex == 1) // Добавление
                {
                    string AddIntoDB = "insert into Доставка values (" + DidMTB.Text + ", @adress, " + assembly + ", " + DStaffCB.SelectedValue + ", '" + DdateMTB.Text + "', " + DsumMTB.Text + ")";
                    SqlCommand AddDeliv = new SqlCommand(AddIntoDB, MainCon);
                    SqlParameter adadress = new SqlParameter("@adress", DadresTB.Text);
                    AddDeliv.Parameters.Add(adadress);
                    try
                    {
                        MainCon.Open();
                        AddDeliv.ExecuteNonQuery();
                        MainCon.Close();
                        RefreshTab();
                        Success3L.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    catch
                    {
                        DErrorL.Visible = true;
                    }
                }
                else // Изменение
                {
                    string UpdateDB = "update Доставка set [Адрес доставки] =  @adress, Сборка = " + assembly + ", Сотрудник = " + DStaffCB.SelectedValue + ", [Дата доставки] = '" + DdateMTB.Text + "', Стоимость = " + DsumMTB.Text + " where [id доставки] = " + DidMTB.Text;
                    SqlCommand UpDeliv = new SqlCommand(UpdateDB, MainCon);
                    SqlParameter upadress = new SqlParameter("@adress", DadresTB.Text);
                    UpDeliv.Parameters.Add(upadress);
                    try
                    {
                        MainCon.Open();
                        UpDeliv.ExecuteNonQuery();
                        MainCon.Close();
                        RefreshTab();
                        Success3L.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    catch
                    {
                        DErrorL.Visible = true;
                    }
                }
            }
        }

        private void SModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SModeCB.SelectedIndex == 0)
            {
                SCodeMTB.Enabled = true;
                SArticCB.Enabled = false;
                //SContCB.Enabled = false;
                SContMTB.Enabled = false;
                SCountNUD.Enabled = false;
                //SSumMTB.Enabled = false;
            }
            else
            {
                if (SModeCB.SelectedIndex == 1)
                {
                    SCodeMTB.Enabled = false;
                    SArticCB.Enabled = true;
                    //SContCB.Enabled = true;
                    SContMTB.Enabled = true;
                    SCountNUD.Enabled = true;
                    //SSumMTB.Enabled = true;
                }
                else
                {
                    SCodeMTB.Enabled = true;
                    SArticCB.Enabled = true;
                    //SContCB.Enabled = true;
                    SContMTB.Enabled = true;
                    SCountNUD.Enabled = true;
                    //SSumMTB.Enabled = true;
                }
            }
        }

        private void SExecB_Click(object sender, EventArgs e)
        {
            if (SModeCB.SelectedIndex == 0) // Удаление
            {
                string DelFromDB = "delete from Продажи where [Код продажи] = " + SCodeMTB.Text;
                SqlCommand DelSale = new SqlCommand(DelFromDB, MainCon);

                MainCon.Open();
                DelSale.ExecuteNonQuery();
                MainCon.Close();
                RefreshTab();
                Success4L.Visible = true;
                TimerOfSuccess.Enabled = true;
                Error4L.Visible = false;

            }
            else
            {
                if (SModeCB.SelectedIndex == 1) // Добавление
                {
                    try
                    {
                        string AddIntoDB;
                        if (SContMTB.Text == "")
                            AddIntoDB = "insert into Продажи values (" + SArticCB.SelectedValue + ", null, " + SCountNUD.Value + ")"; //, " + SSumMTB.Text + ")";
                        else
                            AddIntoDB = "insert into Продажи values (" + SArticCB.SelectedValue + ", " + SContMTB.Text + ", " + SCountNUD.Value + ")"; //, " + SSumMTB.Text + ")";

                        SqlCommand AddSale = new SqlCommand(AddIntoDB, MainCon);

                        MainCon.Open();
                        AddSale.ExecuteNonQuery();
                        MainCon.Close();
                        RefreshTab();
                        Success4L.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    catch
                    {
                        Error4L.Visible = true;
                    }
            }
                else // Изменение
                {
                    string UpdateDB = "update Продажи set [Артикул товара] =  " + SArticCB.SelectedValue + ", [Номер договора] = " + SContMTB.Text + ", Количество = " + SCountNUD.Value + ", where [Код продажи] = " + SCodeMTB.Text; //  [Цена продажи] = " + SSumMTB.Text + ",
                    SqlCommand UpSale = new SqlCommand(UpdateDB, MainCon);
                    try
                    {
                        MainCon.Open();
                        UpSale.ExecuteNonQuery();
                        MainCon.Close();
                        RefreshTab();
                        Success4L.Visible = true;
                        TimerOfSuccess.Enabled = true;
                    }
                    catch
                    {
                        Error4L.Visible = true;
                    }
                }
            }
        }

        private void FDelB_Click(object sender, EventArgs e)
        {
            string DelFromDB = "delete from [Экземпляры мебели] where Артикул = " + FArticCB.SelectedValue;
            SqlCommand DelFurn = new SqlCommand(DelFromDB, MainCon);

            MainCon.Open();
            DelFurn.ExecuteNonQuery();
            MainCon.Close();
            RefreshTab();
            Success5L.Visible = true;
            TimerOfSuccess.Enabled = true;
        }

        private void FAddB_Click(object sender, EventArgs e)
        {
            NewFurniture nF = new NewFurniture(this);
            this.Enabled = false;
            nF.Show();
        }

        public void AddCmdFurniture(string artic, string name, string cat, string spec, string color, string material, string sum)
        {
            string AddIntoDB = "insert into [Экземпляры мебели] values (" + artic + ", @name, N'" + cat + "', N'" + spec + "', @color, N'" + material + "', " + sum + ")";
            SqlCommand AddFurn = new SqlCommand(AddIntoDB, MainCon);
            SqlParameter adname = new SqlParameter("@name", name);
            AddFurn.Parameters.Add(adname);
            SqlParameter adcolor = new SqlParameter("@color", color);
            AddFurn.Parameters.Add(adcolor);

            try
            {
                MainCon.Open();
                AddFurn.ExecuteNonQuery();
                MainCon.Close();

                RefreshTab();
                Success5L.Visible = true;
                TimerOfSuccess.Enabled = true;

            }
            catch
            {
                Error5L.Visible = true;
            }
}

        private void DassemblyCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (DassemblyCheckB.Checked == true)
                assembly = "N'Да'";
            else
                assembly = "N'Нет'";
        }
    }
}
