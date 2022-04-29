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
    public partial class PrivRoom : Form
    {
        UsersForm umf;
        public PrivRoom(UsersForm uF, string name, string pos, string phone, string ed, string salary, string log)
        {
            InitializeComponent();

            umf = uF;

            NameTB.Text = name;
            PositionTB.Text = pos;
            PhoneMTB.Text = phone;
            EdTB.Text = ed;
            SalaryTB.Text = salary;
            LogTB.Text = log;
        }

        private void PrivRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            umf.Enabled = true;
        }

        private void OldPassTB_TextChanged(object sender, EventArgs e)
        {
            if (OldPassTB.Text != "")
                NewPassTB.Enabled = true;
            else
            {
                NewPassTB.Enabled = false;
                NewPassTB.Text = "";
            }
        }

        private void ChangePassB_Click(object sender, EventArgs e)
        {
            if (NewPassTB.Text != "")
            {
                if (umf.ChangePassCmd(OldPassTB.Text, NewPassTB.Text))
                {
                    TimerOfSuccess.Enabled = true;
                    SuccesL.Visible = true;
                    OldPassTB.Text = "";
                    NewPassTB.Text = "";
                }
                else
                {
                    TimerOfSuccess.Enabled = true;
                    ErrorL.Visible = true;
                    OldPassTB.Text = "";
                    NewPassTB.Text = "";
                }
            }
            else
            {
                TimerOfSuccess.Enabled = true;
                ErrorL.Visible = true;
            }
            
        }

        private void TimerOfSuccess_Tick(object sender, EventArgs e)
        {
            TimerOfSuccess.Enabled = false;
            SuccesL.Visible = false;
            ErrorL.Visible = false;
        }
    }
}
