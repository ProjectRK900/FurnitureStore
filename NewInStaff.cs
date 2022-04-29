using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRKCurs
{
    public partial class NewInStaff : Form
    {
        string role = "user", ed = "Сред проф";
        AdminsForm mainF;
        public NewInStaff(AdminsForm mF)
        {
            InitializeComponent();

            mainF = mF;

            EdCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;

            // отключение добавления админов
            RoleCB.Enabled = false;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (NewLogTB.Text == "" || NewPassTB.Text == "")
                ErrorL.Visible = true;
            else
            {
                ErrorL.Visible = false;
                try
                {
                    mainF.AddCmdStaff(NameTB.Text, PositionTB.Text, PhoneMTB.Text, SalaryMTB.Text, ed, role, NewLogTB.Text, NewPassTB.Text);
                }
                catch
                {
                    ErrorL.Visible = true;
                }
                
                this.Close();
            }
        }

        private void NewInStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainF.Enabled = true;
        }

        private void EdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EdCB.SelectedIndex == 0)
                ed = "Сред проф";
            else
            {
                if (EdCB.SelectedIndex == 1)
                    ed = "Высшее";
                else
                    ed = "Сред общее";
            }
        }

        private void RoleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleCB.SelectedIndex == 0)
                role = "user";
            else
                role = "admin";
        }
    }
}
