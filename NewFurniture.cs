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
    public partial class NewFurniture : Form
    {
        AdminsForm mainAF;
        public NewFurniture(AdminsForm af)
        {
            InitializeComponent();

            mainAF = af;
            SpecificCB.SelectedIndex = 0;
            CategoryCB.SelectedIndex = 0;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || ColorTB.Text == "" || ArticMTB.Text == "")
                ErrorL.Visible = true;
            else
            {
                ErrorL.Visible = false;

                mainAF.AddCmdFurniture(ArticMTB.Text, NameTB.Text, CategoryCB.SelectedItem.ToString(), SpecificCB.SelectedItem.ToString(), ColorTB.Text, MaterialCB.SelectedValue.ToString(), SumMTB.Text);

                this.Close();
            }
        }

        private void NewFurniture_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainAF.Enabled = true;
        }

        private void NewFurniture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Курсовик__Мебельный_DataSet2.Материалы". При необходимости она может быть перемещена или удалена.
            this.материалыTableAdapter.Fill(this._Курсовик__Мебельный_DataSet2.Материалы);

        }
    }
}
