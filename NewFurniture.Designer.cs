
namespace WFRKCurs
{
    partial class NewFurniture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFurniture));
            this.ArticMTB = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.lab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SpecificCB = new System.Windows.Forms.ComboBox();
            this.ColorTB = new System.Windows.Forms.TextBox();
            this.MaterialCB = new System.Windows.Forms.ComboBox();
            this.SumMTB = new System.Windows.Forms.MaskedTextBox();
            this.AddB = new System.Windows.Forms.Button();
            this.ErrorL = new System.Windows.Forms.Label();
            this._Курсовик__Мебельный_DataSet2 = new WFRKCurs._Курсовик__Мебельный_DataSet2();
            this.материалыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материалыTableAdapter = new WFRKCurs._Курсовик__Мебельный_DataSet2TableAdapters.МатериалыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Курсовик__Мебельный_DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticMTB
            // 
            this.ArticMTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticMTB.Location = new System.Drawing.Point(210, 7);
            this.ArticMTB.Mask = "000000";
            this.ArticMTB.Name = "ArticMTB";
            this.ArticMTB.Size = new System.Drawing.Size(109, 35);
            this.ArticMTB.TabIndex = 12;
            this.ArticMTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArticMTB.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Артикул:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(210, 57);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(315, 31);
            this.NameTB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(88, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Категория:";
            // 
            // CategoryCB
            // 
            this.CategoryCB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Items.AddRange(new object[] {
            "Гостиная",
            "Спальня",
            "Кухня",
            "Офис",
            "Прихожая",
            "Детская",
            "Дача"});
            this.CategoryCB.Location = new System.Drawing.Point(210, 104);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(191, 32);
            this.CategoryCB.TabIndex = 17;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab.Location = new System.Drawing.Point(41, 152);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(163, 28);
            this.lab.TabIndex = 18;
            this.lab.Text = "Спецификация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(141, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Главный материал:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(54, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Цена за штуку:";
            // 
            // SpecificCB
            // 
            this.SpecificCB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecificCB.FormattingEnabled = true;
            this.SpecificCB.Items.AddRange(new object[] {
            "Классика",
            "Барокко",
            "Рококо",
            "Англия",
            "Модерн",
            "Хай-тек"});
            this.SpecificCB.Location = new System.Drawing.Point(210, 152);
            this.SpecificCB.Name = "SpecificCB";
            this.SpecificCB.Size = new System.Drawing.Size(191, 32);
            this.SpecificCB.TabIndex = 22;
            // 
            // ColorTB
            // 
            this.ColorTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTB.Location = new System.Drawing.Point(210, 198);
            this.ColorTB.Name = "ColorTB";
            this.ColorTB.Size = new System.Drawing.Size(191, 31);
            this.ColorTB.TabIndex = 23;
            // 
            // MaterialCB
            // 
            this.MaterialCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.материалыBindingSource, "id", true));
            this.MaterialCB.DataSource = this.материалыBindingSource;
            this.MaterialCB.DisplayMember = "Наименование";
            this.MaterialCB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialCB.FormattingEnabled = true;
            this.MaterialCB.Location = new System.Drawing.Point(210, 244);
            this.MaterialCB.Name = "MaterialCB";
            this.MaterialCB.Size = new System.Drawing.Size(191, 32);
            this.MaterialCB.TabIndex = 24;
            this.MaterialCB.ValueMember = "id";
            // 
            // SumMTB
            // 
            this.SumMTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumMTB.Location = new System.Drawing.Point(210, 296);
            this.SumMTB.Mask = "000000000";
            this.SumMTB.Name = "SumMTB";
            this.SumMTB.Size = new System.Drawing.Size(191, 35);
            this.SumMTB.TabIndex = 32;
            this.SumMTB.Text = "0";
            this.SumMTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SumMTB.ValidatingType = typeof(System.DateTime);
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.White;
            this.AddB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddB.Location = new System.Drawing.Point(221, 353);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(165, 44);
            this.AddB.TabIndex = 33;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // ErrorL
            // 
            this.ErrorL.AutoSize = true;
            this.ErrorL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorL.ForeColor = System.Drawing.Color.Red;
            this.ErrorL.Location = new System.Drawing.Point(3, 400);
            this.ErrorL.Name = "ErrorL";
            this.ErrorL.Size = new System.Drawing.Size(293, 28);
            this.ErrorL.TabIndex = 36;
            this.ErrorL.Text = "Ошибка! Заполните все поля";
            this.ErrorL.Visible = false;
            // 
            // _Курсовик__Мебельный_DataSet2
            // 
            this._Курсовик__Мебельный_DataSet2.DataSetName = "_Курсовик__Мебельный_DataSet2";
            this._Курсовик__Мебельный_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалыBindingSource
            // 
            this.материалыBindingSource.DataMember = "Материалы";
            this.материалыBindingSource.DataSource = this._Курсовик__Мебельный_DataSet2;
            // 
            // материалыTableAdapter
            // 
            this.материалыTableAdapter.ClearBeforeFill = true;
            // 
            // NewFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 430);
            this.Controls.Add(this.ErrorL);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.SumMTB);
            this.Controls.Add(this.MaterialCB);
            this.Controls.Add(this.ColorTB);
            this.Controls.Add(this.SpecificCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArticMTB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFurniture";
            this.Text = "Новый экземпляр";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewFurniture_FormClosed);
            this.Load += new System.EventHandler(this.NewFurniture_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Курсовик__Мебельный_DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox ArticMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SpecificCB;
        private System.Windows.Forms.TextBox ColorTB;
        private System.Windows.Forms.ComboBox MaterialCB;
        private System.Windows.Forms.MaskedTextBox SumMTB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label ErrorL;
        private _Курсовик__Мебельный_DataSet2 _Курсовик__Мебельный_DataSet2;
        private System.Windows.Forms.BindingSource материалыBindingSource;
        private _Курсовик__Мебельный_DataSet2TableAdapters.МатериалыTableAdapter материалыTableAdapter;
    }
}