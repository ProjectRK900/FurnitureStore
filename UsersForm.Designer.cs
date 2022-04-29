
namespace WFRKCurs
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.ExitB = new System.Windows.Forms.Button();
            this.PrivRoomB = new System.Windows.Forms.Button();
            this.UsersTabControl = new System.Windows.Forms.TabControl();
            this.StaffTP = new System.Windows.Forms.TabPage();
            this.MyDeliv = new System.Windows.Forms.TabPage();
            this.MySales = new System.Windows.Forms.TabPage();
            this.MyClients = new System.Windows.Forms.TabPage();
            this.Furniture = new System.Windows.Forms.TabPage();
            this.Materials = new System.Windows.Forms.TabPage();
            this.MaterialsDGV = new System.Windows.Forms.DataGridView();
            this.FurnitureDGV = new System.Windows.Forms.DataGridView();
            this.StaffDGV = new System.Windows.Forms.DataGridView();
            this.DelivDGV = new System.Windows.Forms.DataGridView();
            this.ClientsDGV = new System.Windows.Forms.DataGridView();
            this.SalesDGV = new System.Windows.Forms.DataGridView();
            this._Курсовик__Мебельный_DataSet4 = new WFRKCurs._Курсовик__Мебельный_DataSet4();
            this.betterFurnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betterFurnitureTableAdapter = new WFRKCurs._Курсовик__Мебельный_DataSet4TableAdapters.BetterFurnitureTableAdapter();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спецификацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.главныйМатериалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаШтукуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshTabB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UsersTabControl.SuspendLayout();
            this.StaffTP.SuspendLayout();
            this.MyDeliv.SuspendLayout();
            this.MySales.SuspendLayout();
            this.MyClients.SuspendLayout();
            this.Furniture.SuspendLayout();
            this.Materials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelivDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Курсовик__Мебельный_DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betterFurnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Red;
            this.ExitB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitB.ForeColor = System.Drawing.Color.Maroon;
            this.ExitB.Location = new System.Drawing.Point(1016, 12);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(82, 34);
            this.ExitB.TabIndex = 7;
            this.ExitB.Text = "Выйти";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // PrivRoomB
            // 
            this.PrivRoomB.BackColor = System.Drawing.Color.White;
            this.PrivRoomB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrivRoomB.Location = new System.Drawing.Point(933, 52);
            this.PrivRoomB.Name = "PrivRoomB";
            this.PrivRoomB.Size = new System.Drawing.Size(165, 44);
            this.PrivRoomB.TabIndex = 8;
            this.PrivRoomB.Text = "Личный кабинет";
            this.PrivRoomB.UseVisualStyleBackColor = false;
            this.PrivRoomB.Click += new System.EventHandler(this.PrivRoomB_Click);
            // 
            // UsersTabControl
            // 
            this.UsersTabControl.Controls.Add(this.MySales);
            this.UsersTabControl.Controls.Add(this.MyClients);
            this.UsersTabControl.Controls.Add(this.MyDeliv);
            this.UsersTabControl.Controls.Add(this.StaffTP);
            this.UsersTabControl.Controls.Add(this.Furniture);
            this.UsersTabControl.Controls.Add(this.Materials);
            this.UsersTabControl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersTabControl.Location = new System.Drawing.Point(12, 12);
            this.UsersTabControl.Name = "UsersTabControl";
            this.UsersTabControl.SelectedIndex = 0;
            this.UsersTabControl.Size = new System.Drawing.Size(915, 465);
            this.UsersTabControl.TabIndex = 9;
            // 
            // StaffTP
            // 
            this.StaffTP.Controls.Add(this.pictureBox5);
            this.StaffTP.Controls.Add(this.pictureBox4);
            this.StaffTP.Controls.Add(this.StaffDGV);
            this.StaffTP.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffTP.Location = new System.Drawing.Point(4, 33);
            this.StaffTP.Name = "StaffTP";
            this.StaffTP.Padding = new System.Windows.Forms.Padding(3);
            this.StaffTP.Size = new System.Drawing.Size(907, 428);
            this.StaffTP.TabIndex = 0;
            this.StaffTP.Text = "Сотрудники";
            this.StaffTP.UseVisualStyleBackColor = true;
            // 
            // MyDeliv
            // 
            this.MyDeliv.Controls.Add(this.DelivDGV);
            this.MyDeliv.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyDeliv.Location = new System.Drawing.Point(4, 33);
            this.MyDeliv.Name = "MyDeliv";
            this.MyDeliv.Padding = new System.Windows.Forms.Padding(3);
            this.MyDeliv.Size = new System.Drawing.Size(907, 428);
            this.MyDeliv.TabIndex = 1;
            this.MyDeliv.Text = "Мои доставки";
            this.MyDeliv.UseVisualStyleBackColor = true;
            // 
            // MySales
            // 
            this.MySales.Controls.Add(this.SalesDGV);
            this.MySales.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MySales.Location = new System.Drawing.Point(4, 33);
            this.MySales.Name = "MySales";
            this.MySales.Size = new System.Drawing.Size(907, 428);
            this.MySales.TabIndex = 2;
            this.MySales.Text = "Мои продажи";
            this.MySales.UseVisualStyleBackColor = true;
            // 
            // MyClients
            // 
            this.MyClients.Controls.Add(this.ClientsDGV);
            this.MyClients.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyClients.Location = new System.Drawing.Point(4, 33);
            this.MyClients.Name = "MyClients";
            this.MyClients.Size = new System.Drawing.Size(907, 428);
            this.MyClients.TabIndex = 3;
            this.MyClients.Text = "Мои клиенты";
            this.MyClients.UseVisualStyleBackColor = true;
            // 
            // Furniture
            // 
            this.Furniture.Controls.Add(this.FurnitureDGV);
            this.Furniture.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Furniture.Location = new System.Drawing.Point(4, 33);
            this.Furniture.Name = "Furniture";
            this.Furniture.Size = new System.Drawing.Size(907, 428);
            this.Furniture.TabIndex = 4;
            this.Furniture.Text = "Справочник мебели";
            this.Furniture.UseVisualStyleBackColor = true;
            // 
            // Materials
            // 
            this.Materials.Controls.Add(this.pictureBox3);
            this.Materials.Controls.Add(this.pictureBox2);
            this.Materials.Controls.Add(this.MaterialsDGV);
            this.Materials.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Materials.Location = new System.Drawing.Point(4, 33);
            this.Materials.Name = "Materials";
            this.Materials.Size = new System.Drawing.Size(907, 428);
            this.Materials.TabIndex = 5;
            this.Materials.Text = "Справочник материалов";
            this.Materials.UseVisualStyleBackColor = true;
            // 
            // MaterialsDGV
            // 
            this.MaterialsDGV.BackgroundColor = System.Drawing.Color.White;
            this.MaterialsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialsDGV.Location = new System.Drawing.Point(3, 0);
            this.MaterialsDGV.Name = "MaterialsDGV";
            this.MaterialsDGV.ReadOnly = true;
            this.MaterialsDGV.RowHeadersWidth = 51;
            this.MaterialsDGV.RowTemplate.Height = 24;
            this.MaterialsDGV.Size = new System.Drawing.Size(524, 425);
            this.MaterialsDGV.TabIndex = 0;
            // 
            // FurnitureDGV
            // 
            this.FurnitureDGV.AutoGenerateColumns = false;
            this.FurnitureDGV.BackgroundColor = System.Drawing.Color.White;
            this.FurnitureDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitureDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.спецификацияDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.главныйМатериалDataGridViewTextBoxColumn,
            this.ценаЗаШтукуDataGridViewTextBoxColumn});
            this.FurnitureDGV.DataSource = this.betterFurnitureBindingSource;
            this.FurnitureDGV.Location = new System.Drawing.Point(3, 3);
            this.FurnitureDGV.Name = "FurnitureDGV";
            this.FurnitureDGV.ReadOnly = true;
            this.FurnitureDGV.RowHeadersWidth = 51;
            this.FurnitureDGV.RowTemplate.Height = 24;
            this.FurnitureDGV.Size = new System.Drawing.Size(891, 413);
            this.FurnitureDGV.TabIndex = 10;
            // 
            // StaffDGV
            // 
            this.StaffDGV.BackgroundColor = System.Drawing.Color.White;
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDGV.Location = new System.Drawing.Point(255, 6);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.ReadOnly = true;
            this.StaffDGV.RowHeadersWidth = 51;
            this.StaffDGV.RowTemplate.Height = 24;
            this.StaffDGV.Size = new System.Drawing.Size(343, 413);
            this.StaffDGV.TabIndex = 10;
            // 
            // DelivDGV
            // 
            this.DelivDGV.BackgroundColor = System.Drawing.Color.White;
            this.DelivDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DelivDGV.Location = new System.Drawing.Point(6, 3);
            this.DelivDGV.Name = "DelivDGV";
            this.DelivDGV.ReadOnly = true;
            this.DelivDGV.RowHeadersWidth = 51;
            this.DelivDGV.RowTemplate.Height = 24;
            this.DelivDGV.Size = new System.Drawing.Size(895, 419);
            this.DelivDGV.TabIndex = 10;
            // 
            // ClientsDGV
            // 
            this.ClientsDGV.BackgroundColor = System.Drawing.Color.White;
            this.ClientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDGV.Location = new System.Drawing.Point(3, 3);
            this.ClientsDGV.Name = "ClientsDGV";
            this.ClientsDGV.ReadOnly = true;
            this.ClientsDGV.RowHeadersWidth = 51;
            this.ClientsDGV.RowTemplate.Height = 24;
            this.ClientsDGV.Size = new System.Drawing.Size(901, 422);
            this.ClientsDGV.TabIndex = 10;
            // 
            // SalesDGV
            // 
            this.SalesDGV.BackgroundColor = System.Drawing.Color.White;
            this.SalesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDGV.Location = new System.Drawing.Point(3, 3);
            this.SalesDGV.Name = "SalesDGV";
            this.SalesDGV.ReadOnly = true;
            this.SalesDGV.RowHeadersWidth = 51;
            this.SalesDGV.RowTemplate.Height = 24;
            this.SalesDGV.Size = new System.Drawing.Size(901, 422);
            this.SalesDGV.TabIndex = 10;
            // 
            // _Курсовик__Мебельный_DataSet4
            // 
            this._Курсовик__Мебельный_DataSet4.DataSetName = "_Курсовик__Мебельный_DataSet4";
            this._Курсовик__Мебельный_DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betterFurnitureBindingSource
            // 
            this.betterFurnitureBindingSource.DataMember = "BetterFurniture";
            this.betterFurnitureBindingSource.DataSource = this._Курсовик__Мебельный_DataSet4;
            // 
            // betterFurnitureTableAdapter
            // 
            this.betterFurnitureTableAdapter.ClearBeforeFill = true;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            this.артикулDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // спецификацияDataGridViewTextBoxColumn
            // 
            this.спецификацияDataGridViewTextBoxColumn.DataPropertyName = "Спецификация";
            this.спецификацияDataGridViewTextBoxColumn.HeaderText = "Спецификация";
            this.спецификацияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.спецификацияDataGridViewTextBoxColumn.Name = "спецификацияDataGridViewTextBoxColumn";
            this.спецификацияDataGridViewTextBoxColumn.ReadOnly = true;
            this.спецификацияDataGridViewTextBoxColumn.Width = 135;
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            this.цветDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // главныйМатериалDataGridViewTextBoxColumn
            // 
            this.главныйМатериалDataGridViewTextBoxColumn.DataPropertyName = "Главный материал";
            this.главныйМатериалDataGridViewTextBoxColumn.HeaderText = "Главный материал";
            this.главныйМатериалDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.главныйМатериалDataGridViewTextBoxColumn.Name = "главныйМатериалDataGridViewTextBoxColumn";
            this.главныйМатериалDataGridViewTextBoxColumn.ReadOnly = true;
            this.главныйМатериалDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаЗаШтукуDataGridViewTextBoxColumn
            // 
            this.ценаЗаШтукуDataGridViewTextBoxColumn.DataPropertyName = "Цена за штуку";
            this.ценаЗаШтукуDataGridViewTextBoxColumn.HeaderText = "Цена за штуку";
            this.ценаЗаШтукуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаЗаШтукуDataGridViewTextBoxColumn.Name = "ценаЗаШтукуDataGridViewTextBoxColumn";
            this.ценаЗаШтукуDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаЗаШтукуDataGridViewTextBoxColumn.Width = 125;
            // 
            // RefreshTabB
            // 
            this.RefreshTabB.BackColor = System.Drawing.Color.White;
            this.RefreshTabB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshTabB.Location = new System.Drawing.Point(933, 396);
            this.RefreshTabB.Name = "RefreshTabB";
            this.RefreshTabB.Size = new System.Drawing.Size(165, 65);
            this.RefreshTabB.TabIndex = 10;
            this.RefreshTabB.Text = "Обновить информацию";
            this.RefreshTabB.UseVisualStyleBackColor = false;
            this.RefreshTabB.Click += new System.EventHandler(this.RefreshTabB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WFRKCurs.Properties.Resources.UserPicture;
            this.pictureBox1.Location = new System.Drawing.Point(933, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = global::WFRKCurs.Properties.Resources.UserPicture5;
            this.pictureBox5.Location = new System.Drawing.Point(6, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(243, 409);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::WFRKCurs.Properties.Resources.UserPicture4;
            this.pictureBox4.Location = new System.Drawing.Point(604, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(297, 412);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::WFRKCurs.Properties.Resources.UserPicture3;
            this.pictureBox3.Location = new System.Drawing.Point(585, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(277, 204);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::WFRKCurs.Properties.Resources.UserPicture2;
            this.pictureBox2.Location = new System.Drawing.Point(533, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(363, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RefreshTabB);
            this.Controls.Add(this.UsersTabControl);
            this.Controls.Add(this.PrivRoomB);
            this.Controls.Add(this.ExitB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.Text = "Welcome, ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersForm_FormClosed);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.UsersTabControl.ResumeLayout(false);
            this.StaffTP.ResumeLayout(false);
            this.MyDeliv.ResumeLayout(false);
            this.MySales.ResumeLayout(false);
            this.MyClients.ResumeLayout(false);
            this.Furniture.ResumeLayout(false);
            this.Materials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelivDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Курсовик__Мебельный_DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betterFurnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button PrivRoomB;
        private System.Windows.Forms.TabControl UsersTabControl;
        private System.Windows.Forms.TabPage MySales;
        private System.Windows.Forms.DataGridView SalesDGV;
        private System.Windows.Forms.TabPage MyClients;
        private System.Windows.Forms.DataGridView ClientsDGV;
        private System.Windows.Forms.TabPage MyDeliv;
        private System.Windows.Forms.DataGridView DelivDGV;
        private System.Windows.Forms.TabPage StaffTP;
        private System.Windows.Forms.TabPage Furniture;
        private System.Windows.Forms.DataGridView FurnitureDGV;
        private System.Windows.Forms.TabPage Materials;
        private System.Windows.Forms.DataGridView MaterialsDGV;
        public System.Windows.Forms.DataGridView StaffDGV;
        private _Курсовик__Мебельный_DataSet4 _Курсовик__Мебельный_DataSet4;
        private System.Windows.Forms.BindingSource betterFurnitureBindingSource;
        private _Курсовик__Мебельный_DataSet4TableAdapters.BetterFurnitureTableAdapter betterFurnitureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спецификацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn главныйМатериалDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаШтукуDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RefreshTabB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}