
namespace WFRKCurs
{
    partial class PrivRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivRoom));
            this.PositionTB = new System.Windows.Forms.TextBox();
            this.OldPassTB = new System.Windows.Forms.TextBox();
            this.LogTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdTB = new System.Windows.Forms.TextBox();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.ChangePassB = new System.Windows.Forms.Button();
            this.OldPassL = new System.Windows.Forms.Label();
            this.NewPassL = new System.Windows.Forms.Label();
            this.NewPassTB = new System.Windows.Forms.TextBox();
            this.PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.SuccesL = new System.Windows.Forms.Label();
            this.ErrorL = new System.Windows.Forms.Label();
            this.TimerOfSuccess = new System.Windows.Forms.Timer(this.components);
            this.PotionPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PotionPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionTB
            // 
            this.PositionTB.Enabled = false;
            this.PositionTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionTB.Location = new System.Drawing.Point(39, 120);
            this.PositionTB.Name = "PositionTB";
            this.PositionTB.Size = new System.Drawing.Size(315, 31);
            this.PositionTB.TabIndex = 30;
            this.PositionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OldPassTB
            // 
            this.OldPassTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPassTB.Location = new System.Drawing.Point(370, 529);
            this.OldPassTB.Name = "OldPassTB";
            this.OldPassTB.PasswordChar = '*';
            this.OldPassTB.Size = new System.Drawing.Size(258, 31);
            this.OldPassTB.TabIndex = 29;
            this.OldPassTB.TextChanged += new System.EventHandler(this.OldPassTB_TextChanged);
            // 
            // LogTB
            // 
            this.LogTB.Enabled = false;
            this.LogTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTB.Location = new System.Drawing.Point(96, 439);
            this.LogTB.Name = "LogTB";
            this.LogTB.Size = new System.Drawing.Size(258, 31);
            this.LogTB.TabIndex = 28;
            this.LogTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(129, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Образование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(183, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Оклад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(148, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Должность";
            // 
            // NameTB
            // 
            this.NameTB.Enabled = false;
            this.NameTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(39, 40);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(315, 31);
            this.NameTB.TabIndex = 21;
            this.NameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "ФИО";
            // 
            // EdTB
            // 
            this.EdTB.Enabled = false;
            this.EdTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EdTB.Location = new System.Drawing.Point(39, 302);
            this.EdTB.Name = "EdTB";
            this.EdTB.Size = new System.Drawing.Size(315, 31);
            this.EdTB.TabIndex = 32;
            this.EdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalaryTB
            // 
            this.SalaryTB.Enabled = false;
            this.SalaryTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryTB.Location = new System.Drawing.Point(96, 388);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(258, 31);
            this.SalaryTB.TabIndex = 33;
            this.SalaryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangePassB
            // 
            this.ChangePassB.BackColor = System.Drawing.Color.White;
            this.ChangePassB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassB.Location = new System.Drawing.Point(417, 470);
            this.ChangePassB.Name = "ChangePassB";
            this.ChangePassB.Size = new System.Drawing.Size(173, 51);
            this.ChangePassB.TabIndex = 35;
            this.ChangePassB.Text = "Изменить пароль";
            this.ChangePassB.UseVisualStyleBackColor = false;
            this.ChangePassB.Click += new System.EventHandler(this.ChangePassB_Click);
            // 
            // OldPassL
            // 
            this.OldPassL.AutoSize = true;
            this.OldPassL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPassL.Location = new System.Drawing.Point(200, 529);
            this.OldPassL.Name = "OldPassL";
            this.OldPassL.Size = new System.Drawing.Size(164, 28);
            this.OldPassL.TabIndex = 36;
            this.OldPassL.Text = "Старый пароль:";
            // 
            // NewPassL
            // 
            this.NewPassL.AutoSize = true;
            this.NewPassL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassL.Location = new System.Drawing.Point(205, 572);
            this.NewPassL.Name = "NewPassL";
            this.NewPassL.Size = new System.Drawing.Size(159, 28);
            this.NewPassL.TabIndex = 37;
            this.NewPassL.Text = "Новый пароль:";
            // 
            // NewPassTB
            // 
            this.NewPassTB.Enabled = false;
            this.NewPassTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassTB.Location = new System.Drawing.Point(370, 572);
            this.NewPassTB.Name = "NewPassTB";
            this.NewPassTB.Size = new System.Drawing.Size(258, 31);
            this.NewPassTB.TabIndex = 38;
            // 
            // PhoneMTB
            // 
            this.PhoneMTB.Enabled = false;
            this.PhoneMTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMTB.Location = new System.Drawing.Point(39, 211);
            this.PhoneMTB.Mask = "+7 (000) 000 00-00";
            this.PhoneMTB.Name = "PhoneMTB";
            this.PhoneMTB.Size = new System.Drawing.Size(315, 35);
            this.PhoneMTB.TabIndex = 39;
            this.PhoneMTB.Text = "0000000000";
            this.PhoneMTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuccesL
            // 
            this.SuccesL.AutoSize = true;
            this.SuccesL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccesL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SuccesL.Location = new System.Drawing.Point(313, 480);
            this.SuccesL.Name = "SuccesL";
            this.SuccesL.Size = new System.Drawing.Size(76, 28);
            this.SuccesL.TabIndex = 40;
            this.SuccesL.Text = "Успех!";
            this.SuccesL.Visible = false;
            // 
            // ErrorL
            // 
            this.ErrorL.AutoSize = true;
            this.ErrorL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorL.ForeColor = System.Drawing.Color.Red;
            this.ErrorL.Location = new System.Drawing.Point(360, 414);
            this.ErrorL.Name = "ErrorL";
            this.ErrorL.Size = new System.Drawing.Size(293, 56);
            this.ErrorL.TabIndex = 41;
            this.ErrorL.Text = "Ошибка! Неверный пароль\r\nили новый пароль не введён";
            this.ErrorL.Visible = false;
            // 
            // TimerOfSuccess
            // 
            this.TimerOfSuccess.Interval = 7000;
            this.TimerOfSuccess.Tick += new System.EventHandler(this.TimerOfSuccess_Tick);
            // 
            // PotionPB
            // 
            this.PotionPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PotionPB.Image = global::WFRKCurs.Properties.Resources.potion;
            this.PotionPB.Location = new System.Drawing.Point(360, 14);
            this.PotionPB.Name = "PotionPB";
            this.PotionPB.Size = new System.Drawing.Size(329, 397);
            this.PotionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PotionPB.TabIndex = 42;
            this.PotionPB.TabStop = false;
            // 
            // PrivRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 639);
            this.Controls.Add(this.PotionPB);
            this.Controls.Add(this.ErrorL);
            this.Controls.Add(this.SuccesL);
            this.Controls.Add(this.PhoneMTB);
            this.Controls.Add(this.NewPassTB);
            this.Controls.Add(this.NewPassL);
            this.Controls.Add(this.OldPassL);
            this.Controls.Add(this.ChangePassB);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.EdTB);
            this.Controls.Add(this.PositionTB);
            this.Controls.Add(this.OldPassTB);
            this.Controls.Add(this.LogTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrivRoom";
            this.Text = "Информация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrivRoom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PotionPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PositionTB;
        private System.Windows.Forms.TextBox OldPassTB;
        private System.Windows.Forms.TextBox LogTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdTB;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.Button ChangePassB;
        private System.Windows.Forms.Label OldPassL;
        private System.Windows.Forms.Label NewPassL;
        private System.Windows.Forms.TextBox NewPassTB;
        private System.Windows.Forms.MaskedTextBox PhoneMTB;
        private System.Windows.Forms.Label SuccesL;
        private System.Windows.Forms.Label ErrorL;
        private System.Windows.Forms.Timer TimerOfSuccess;
        private System.Windows.Forms.PictureBox PotionPB;
    }
}