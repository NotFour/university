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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labelBakingPerMonth.Location = new System.Drawing.Point(10, 190);
            this.labelBakingPerMonth.Name = "labelSuperior";
            this.labelBakingPerMonth.Size = new System.Drawing.Size(93, 13);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ошибка ввода";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(454, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(454, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(454, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(454, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(454, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(454, 10);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Глава отделения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
    }
}

