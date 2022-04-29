
namespace WFRKCurs
{
    partial class UpdateStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStaff));
            this.Error3l = new System.Windows.Forms.Label();
            this.Error2l = new System.Windows.Forms.Label();
            this.ErrorL = new System.Windows.Forms.Label();
            this.UpdateB = new System.Windows.Forms.Button();
            this.PositionTB = new System.Windows.Forms.TextBox();
            this.SalaryMTB = new System.Windows.Forms.MaskedTextBox();
            this.PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.EdCB = new System.Windows.Forms.ComboBox();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.NewPassTB = new System.Windows.Forms.TextBox();
            this.NewLogTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Error4L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Error3l
            // 
            this.Error3l.AutoSize = true;
            this.Error3l.BackColor = System.Drawing.Color.Transparent;
            this.Error3l.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error3l.ForeColor = System.Drawing.Color.Red;
            this.Error3l.Location = new System.Drawing.Point(41, 325);
            this.Error3l.Name = "Error3l";
            this.Error3l.Size = new System.Drawing.Size(22, 28);
            this.Error3l.TabIndex = 43;
            this.Error3l.Text = "*";
            // 
            // Error2l
            // 
            this.Error2l.AutoSize = true;
            this.Error2l.BackColor = System.Drawing.Color.Transparent;
            this.Error2l.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error2l.ForeColor = System.Drawing.Color.Red;
            this.Error2l.Location = new System.Drawing.Point(41, 280);
            this.Error2l.Name = "Error2l";
            this.Error2l.Size = new System.Drawing.Size(22, 28);
            this.Error2l.TabIndex = 42;
            this.Error2l.Text = "*";
            // 
            // ErrorL
            // 
            this.ErrorL.AutoSize = true;
            this.ErrorL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorL.ForeColor = System.Drawing.Color.Red;
            this.ErrorL.Location = new System.Drawing.Point(11, 413);
            this.ErrorL.Name = "ErrorL";
            this.ErrorL.Size = new System.Drawing.Size(229, 28);
            this.ErrorL.TabIndex = 41;
            this.ErrorL.Text = "* - обязательные поля";
            this.ErrorL.Visible = false;
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.White;
            this.UpdateB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateB.Location = new System.Drawing.Point(231, 366);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(165, 44);
            this.UpdateB.TabIndex = 40;
            this.UpdateB.Text = "Обновить";
            this.UpdateB.UseVisualStyleBackColor = false;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // PositionTB
            // 
            this.PositionTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionTB.Location = new System.Drawing.Point(159, 49);
            this.PositionTB.Name = "PositionTB";
            this.PositionTB.Size = new System.Drawing.Size(225, 31);
            this.PositionTB.TabIndex = 39;
            // 
            // SalaryMTB
            // 
            this.SalaryMTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryMTB.Location = new System.Drawing.Point(159, 134);
            this.SalaryMTB.Mask = "9999999";
            this.SalaryMTB.Name = "SalaryMTB";
            this.SalaryMTB.Size = new System.Drawing.Size(165, 35);
            this.SalaryMTB.TabIndex = 38;
            this.SalaryMTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneMTB
            // 
            this.PhoneMTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMTB.Location = new System.Drawing.Point(159, 93);
            this.PhoneMTB.Mask = "+7 (000) 000 00-00";
            this.PhoneMTB.Name = "PhoneMTB";
            this.PhoneMTB.Size = new System.Drawing.Size(225, 35);
            this.PhoneMTB.TabIndex = 37;
            this.PhoneMTB.Text = "9999999999";
            this.PhoneMTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EdCB
            // 
            this.EdCB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EdCB.FormattingEnabled = true;
            this.EdCB.Items.AddRange(new object[] {
            "Среднее профессиональное",
            "Высшее",
            "Среднее общеобразовательное"});
            this.EdCB.Location = new System.Drawing.Point(159, 183);
            this.EdCB.Name = "EdCB";
            this.EdCB.Size = new System.Drawing.Size(315, 32);
            this.EdCB.TabIndex = 36;
            this.EdCB.SelectedIndexChanged += new System.EventHandler(this.EdCB_SelectedIndexChanged);
            // 
            // RoleCB
            // 
            this.RoleCB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.RoleCB.Location = new System.Drawing.Point(159, 232);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(103, 32);
            this.RoleCB.TabIndex = 35;
            this.RoleCB.SelectedIndexChanged += new System.EventHandler(this.RoleCB_SelectedIndexChanged);
            // 
            // NewPassTB
            // 
            this.NewPassTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassTB.Location = new System.Drawing.Point(159, 322);
            this.NewPassTB.Name = "NewPassTB";
            this.NewPassTB.Size = new System.Drawing.Size(315, 31);
            this.NewPassTB.TabIndex = 34;
            // 
            // NewLogTB
            // 
            this.NewLogTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLogTB.Location = new System.Drawing.Point(159, 277);
            this.NewLogTB.Name = "NewLogTB";
            this.NewLogTB.Size = new System.Drawing.Size(315, 31);
            this.NewLogTB.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(61, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(75, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Логин:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Роль в БД:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Образование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(74, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Оклад:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Телефон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Должность:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(159, 6);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(315, 31);
            this.NameTB.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "ФИО:";
            // 
            // Error4L
            // 
            this.Error4L.AutoSize = true;
            this.Error4L.BackColor = System.Drawing.Color.Transparent;
            this.Error4L.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error4L.ForeColor = System.Drawing.Color.Red;
            this.Error4L.Location = new System.Drawing.Point(29, 96);
            this.Error4L.Name = "Error4L";
            this.Error4L.Size = new System.Drawing.Size(22, 28);
            this.Error4L.TabIndex = 44;
            this.Error4L.Text = "*";
            // 
            // UpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.Error4L);
            this.Controls.Add(this.Error3l);
            this.Controls.Add(this.Error2l);
            this.Controls.Add(this.ErrorL);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.PositionTB);
            this.Controls.Add(this.SalaryMTB);
            this.Controls.Add(this.PhoneMTB);
            this.Controls.Add(this.EdCB);
            this.Controls.Add(this.RoleCB);
            this.Controls.Add(this.NewPassTB);
            this.Controls.Add(this.NewLogTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateStaff";
            this.Text = "Обновить информацию";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateStaff_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error3l;
        private System.Windows.Forms.Label Error2l;
        private System.Windows.Forms.Label ErrorL;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.TextBox PositionTB;
        private System.Windows.Forms.MaskedTextBox SalaryMTB;
        private System.Windows.Forms.MaskedTextBox PhoneMTB;
        private System.Windows.Forms.ComboBox EdCB;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.TextBox NewPassTB;
        private System.Windows.Forms.TextBox NewLogTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Error4L;
    }
}