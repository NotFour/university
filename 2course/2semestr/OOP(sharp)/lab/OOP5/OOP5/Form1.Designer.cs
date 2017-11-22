using System;

namespace OOP5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnterpriseName = new System.Windows.Forms.Label();
            this.labelWorkmans = new System.Windows.Forms.Label();
            this.labelPaymentPerHour = new System.Windows.Forms.Label();
            this.labelBestWorker = new System.Windows.Forms.Label();
            this.labelHoursPerMonth = new System.Windows.Forms.Label();
            this.labelImposing = new System.Windows.Forms.Label();
            this.labelBakingPerMonth = new System.Windows.Forms.Label();
            this.tbEnterpriseName = new System.Windows.Forms.TextBox();
            this.tbWorkmans = new System.Windows.Forms.TextBox();
            this.tbPaymentPerHour = new System.Windows.Forms.TextBox();
            this.tbBestWorker = new System.Windows.Forms.TextBox();
            this.tbHoursPerMonth = new System.Windows.Forms.TextBox();
            this.tbImposing = new System.Windows.Forms.TextBox();
            this.tbSuperior = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelError2 = new System.Windows.Forms.Label();
            this.buttonCreate2 = new System.Windows.Forms.Button();
            this.tbBakingPerMonth = new System.Windows.Forms.TextBox();
            this.tbImposing2 = new System.Windows.Forms.TextBox();
            this.tbHoursPerMonth2 = new System.Windows.Forms.TextBox();
            this.tbBestWorker2 = new System.Windows.Forms.TextBox();
            this.tbPayment2 = new System.Windows.Forms.TextBox();
            this.tbWorkmans2 = new System.Windows.Forms.TextBox();
            this.tbEnterpriseName2 = new System.Windows.Forms.TextBox();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnterpriseName
            // 
            this.labelEnterpriseName.AutoEllipsis = true;
            this.labelEnterpriseName.AutoSize = true;
            this.labelEnterpriseName.Location = new System.Drawing.Point(10, 10);
            this.labelEnterpriseName.MaximumSize = new System.Drawing.Size(125, 15);
            this.labelEnterpriseName.Name = "labelEnterpriseName";
            this.labelEnterpriseName.Size = new System.Drawing.Size(125, 13);
            this.labelEnterpriseName.TabIndex = 0;
            this.labelEnterpriseName.Text = "Название предприятия";
            // 
            // labelWorkmans
            // 
            this.labelWorkmans.AutoEllipsis = true;
            this.labelWorkmans.AutoSize = true;
            this.labelWorkmans.Location = new System.Drawing.Point(10, 40);
            this.labelWorkmans.Name = "labelWorkmans";
            this.labelWorkmans.Size = new System.Drawing.Size(128, 13);
            this.labelWorkmans.TabIndex = 1;
            this.labelWorkmans.Text = "Количество работников";
            // 
            // labelPaymentPerHour
            // 
            this.labelPaymentPerHour.AutoEllipsis = true;
            this.labelPaymentPerHour.AutoSize = true;
            this.labelPaymentPerHour.Location = new System.Drawing.Point(10, 70);
            this.labelPaymentPerHour.Name = "labelPaymentPerHour";
            this.labelPaymentPerHour.Size = new System.Drawing.Size(51, 13);
            this.labelPaymentPerHour.TabIndex = 2;
            this.labelPaymentPerHour.Text = "ЗП в час";
            // 
            // labelBestWorker
            // 
            this.labelBestWorker.AutoEllipsis = true;
            this.labelBestWorker.AutoSize = true;
            this.labelBestWorker.Location = new System.Drawing.Point(10, 100);
            this.labelBestWorker.Name = "labelBestWorker";
            this.labelBestWorker.Size = new System.Drawing.Size(95, 13);
            this.labelBestWorker.TabIndex = 3;
            this.labelBestWorker.Text = "Лучший работник";
            // 
            // labelHoursPerMonth
            // 
            this.labelHoursPerMonth.AutoEllipsis = true;
            this.labelHoursPerMonth.AutoSize = true;
            this.labelHoursPerMonth.Location = new System.Drawing.Point(10, 130);
            this.labelHoursPerMonth.Name = "labelHoursPerMonth";
            this.labelHoursPerMonth.Size = new System.Drawing.Size(124, 13);
            this.labelHoursPerMonth.TabIndex = 4;
            this.labelHoursPerMonth.Text = "Рабочих часов в месяц";
            // 
            // labelImposing
            // 
            this.labelImposing.AutoEllipsis = true;
            this.labelImposing.AutoSize = true;
            this.labelImposing.Location = new System.Drawing.Point(10, 160);
            this.labelImposing.Name = "labelImposing";
            this.labelImposing.Size = new System.Drawing.Size(84, 13);
            this.labelImposing.TabIndex = 5;
            this.labelImposing.Text = "Размер налога";
            // 
            // labelBakingPerMonth
            // 
            this.labelBakingPerMonth.AutoEllipsis = true;
            this.labelBakingPerMonth.AutoSize = true;
            this.labelBakingPerMonth.Location = new System.Drawing.Point(308, 191);
            this.labelBakingPerMonth.Name = "labelBakingPerMonth";
            this.labelBakingPerMonth.Size = new System.Drawing.Size(95, 13);
            this.labelBakingPerMonth.TabIndex = 6;
            this.labelBakingPerMonth.Text = "Выпечки в месяц";
            // 
            // tbEnterpriseName
            // 
            this.tbEnterpriseName.Location = new System.Drawing.Point(156, 10);
            this.tbEnterpriseName.Name = "tbEnterpriseName";
            this.tbEnterpriseName.Size = new System.Drawing.Size(100, 20);
            this.tbEnterpriseName.TabIndex = 7;
            // 
            // tbWorkmans
            // 
            this.tbWorkmans.Location = new System.Drawing.Point(156, 40);
            this.tbWorkmans.Name = "tbWorkmans";
            this.tbWorkmans.Size = new System.Drawing.Size(100, 20);
            this.tbWorkmans.TabIndex = 8;
            // 
            // tbPaymentPerHour
            // 
            this.tbPaymentPerHour.Location = new System.Drawing.Point(156, 70);
            this.tbPaymentPerHour.Name = "tbPaymentPerHour";
            this.tbPaymentPerHour.Size = new System.Drawing.Size(100, 20);
            this.tbPaymentPerHour.TabIndex = 9;
            // 
            // tbBestWorker
            // 
            this.tbBestWorker.Location = new System.Drawing.Point(156, 100);
            this.tbBestWorker.Name = "tbBestWorker";
            this.tbBestWorker.Size = new System.Drawing.Size(100, 20);
            this.tbBestWorker.TabIndex = 10;
            // 
            // tbHoursPerMonth
            // 
            this.tbHoursPerMonth.Location = new System.Drawing.Point(156, 130);
            this.tbHoursPerMonth.Name = "tbHoursPerMonth";
            this.tbHoursPerMonth.Size = new System.Drawing.Size(100, 20);
            this.tbHoursPerMonth.TabIndex = 11;
            // 
            // tbImposing
            // 
            this.tbImposing.Location = new System.Drawing.Point(156, 160);
            this.tbImposing.Name = "tbImposing";
            this.tbImposing.Size = new System.Drawing.Size(100, 20);
            this.tbImposing.TabIndex = 12;
            // 
            // tbSuperior
            // 
            this.tbSuperior.Location = new System.Drawing.Point(156, 190);
            this.tbSuperior.Name = "tbSuperior";
            this.tbSuperior.Size = new System.Drawing.Size(100, 20);
            this.tbSuperior.TabIndex = 13;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(785, 217);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(156, 217);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.AcceptsTab = true;
            this.tbOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbOutput.Location = new System.Drawing.Point(661, 17);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.ShortcutsEnabled = false;
            this.tbOutput.Size = new System.Drawing.Size(224, 193);
            this.tbOutput.TabIndex = 14;
            this.tbOutput.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(10, 227);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(80, 13);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "Ошибка ввода";
            this.labelError.Visible = false;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(661, 217);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(100, 23);
            this.buttonShow.TabIndex = 36;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Location = new System.Drawing.Point(308, 222);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(80, 13);
            this.labelError2.TabIndex = 35;
            this.labelError2.Text = "Ошибка ввода";
            this.labelError2.Visible = false;
            // 
            // buttonCreate2
            // 
            this.buttonCreate2.Location = new System.Drawing.Point(454, 217);
            this.buttonCreate2.Name = "buttonCreate2";
            this.buttonCreate2.Size = new System.Drawing.Size(100, 23);
            this.buttonCreate2.TabIndex = 34;
            this.buttonCreate2.Text = "Создать";
            this.buttonCreate2.UseVisualStyleBackColor = true;
            this.buttonCreate2.Click += new System.EventHandler(this.buttonCreate2_Click);
            // 
            // tbBakingPerMonth
            // 
            this.tbBakingPerMonth.Location = new System.Drawing.Point(454, 191);
            this.tbBakingPerMonth.Name = "tbBakingPerMonth";
            this.tbBakingPerMonth.Size = new System.Drawing.Size(100, 20);
            this.tbBakingPerMonth.TabIndex = 32;
            // 
            // tbImposing2
            // 
            this.tbImposing2.Location = new System.Drawing.Point(454, 160);
            this.tbImposing2.Name = "tbImposing2";
            this.tbImposing2.Size = new System.Drawing.Size(100, 20);
            this.tbImposing2.TabIndex = 31;
            // 
            // tbHoursPerMonth2
            // 
            this.tbHoursPerMonth2.Location = new System.Drawing.Point(454, 130);
            this.tbHoursPerMonth2.Name = "tbHoursPerMonth2";
            this.tbHoursPerMonth2.Size = new System.Drawing.Size(100, 20);
            this.tbHoursPerMonth2.TabIndex = 30;
            // 
            // tbBestWorker2
            // 
            this.tbBestWorker2.Location = new System.Drawing.Point(454, 100);
            this.tbBestWorker2.Name = "tbBestWorker2";
            this.tbBestWorker2.Size = new System.Drawing.Size(100, 20);
            this.tbBestWorker2.TabIndex = 29;
            // 
            // tbPayment2
            // 
            this.tbPayment2.Location = new System.Drawing.Point(454, 70);
            this.tbPayment2.Name = "tbPayment2";
            this.tbPayment2.Size = new System.Drawing.Size(100, 20);
            this.tbPayment2.TabIndex = 28;
            // 
            // tbWorkmans2
            // 
            this.tbWorkmans2.Location = new System.Drawing.Point(454, 40);
            this.tbWorkmans2.Name = "tbWorkmans2";
            this.tbWorkmans2.Size = new System.Drawing.Size(100, 20);
            this.tbWorkmans2.TabIndex = 27;
            // 
            // tbEnterpriseName2
            // 
            this.tbEnterpriseName2.Location = new System.Drawing.Point(454, 10);
            this.tbEnterpriseName2.Name = "tbEnterpriseName2";
            this.tbEnterpriseName2.Size = new System.Drawing.Size(100, 20);
            this.tbEnterpriseName2.TabIndex = 26;
            // 
            // labelSuperior
            // 
            this.labelSuperior.AutoEllipsis = true;
            this.labelSuperior.AutoSize = true;
            this.labelSuperior.Location = new System.Drawing.Point(10, 190);
            this.labelSuperior.Name = "labelSuperior";
            this.labelSuperior.Size = new System.Drawing.Size(93, 13);
            this.labelSuperior.TabIndex = 25;
            this.labelSuperior.Text = "Глава отделения";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Размер налога";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Рабочих часов в месяц";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Лучший работник";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ЗП в час";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Количество работников";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 10);
            this.label8.MaximumSize = new System.Drawing.Size(125, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Название предприятия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 247);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.buttonCreate2);
            this.Controls.Add(this.tbBakingPerMonth);
            this.Controls.Add(this.tbImposing2);
            this.Controls.Add(this.tbHoursPerMonth2);
            this.Controls.Add(this.tbBestWorker2);
            this.Controls.Add(this.tbPayment2);
            this.Controls.Add(this.tbWorkmans2);
            this.Controls.Add(this.tbEnterpriseName2);
            this.Controls.Add(this.labelSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tbSuperior);
            this.Controls.Add(this.tbImposing);
            this.Controls.Add(this.tbHoursPerMonth);
            this.Controls.Add(this.tbBestWorker);
            this.Controls.Add(this.tbPaymentPerHour);
            this.Controls.Add(this.tbWorkmans);
            this.Controls.Add(this.tbEnterpriseName);
            this.Controls.Add(this.labelBakingPerMonth);
            this.Controls.Add(this.labelImposing);
            this.Controls.Add(this.labelHoursPerMonth);
            this.Controls.Add(this.labelBestWorker);
            this.Controls.Add(this.labelPaymentPerHour);
            this.Controls.Add(this.labelWorkmans);
            this.Controls.Add(this.labelEnterpriseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (Program.CheckingTBsPersonnelDepartment())
            {
                labelError.Visible = false;
                Program.CreatePersonnelDepartment();
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void buttonCreate2_Click(object sender, EventArgs e)
        {
            if (Program.CheckingTBsBakingDepartment())
            {
                labelError2.Visible = false;
                Program.CreateBakingDepartment();
            }
            else
            {
                labelError2.Visible = true;
            }
        }

        private void buttonShow_Click(object sender, System.EventArgs e)
        {
            Program.ShowAllEnterprises();
        }

        #endregion

        public System.Windows.Forms.Label labelEnterpriseName;
        public System.Windows.Forms.Label labelWorkmans;
        public System.Windows.Forms.Label labelPaymentPerHour;
        public System.Windows.Forms.Label labelBestWorker;
        public System.Windows.Forms.Label labelHoursPerMonth;
        public System.Windows.Forms.Label labelImposing;
        public System.Windows.Forms.Label labelBakingPerMonth;
        public System.Windows.Forms.TextBox tbEnterpriseName;
        public System.Windows.Forms.TextBox tbWorkmans;
        public System.Windows.Forms.TextBox tbPaymentPerHour;
        public System.Windows.Forms.TextBox tbBestWorker;
        public System.Windows.Forms.TextBox tbHoursPerMonth;
        public System.Windows.Forms.TextBox tbImposing;
        public System.Windows.Forms.TextBox tbSuperior;
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Button buttonCreate;
        public System.Windows.Forms.TextBox tbOutput;
        public System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonShow;
        public System.Windows.Forms.Label labelError2;
        public System.Windows.Forms.Button buttonCreate2;
        public System.Windows.Forms.TextBox tbBakingPerMonth;
        public System.Windows.Forms.TextBox tbImposing2;
        public System.Windows.Forms.TextBox tbHoursPerMonth2;
        public System.Windows.Forms.TextBox tbBestWorker2;
        public System.Windows.Forms.TextBox tbPayment2;
        public System.Windows.Forms.TextBox tbWorkmans2;
        public System.Windows.Forms.TextBox tbEnterpriseName2;
        public System.Windows.Forms.Label labelSuperior;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
    }
}

