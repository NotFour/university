using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace OOP4
{
    static class Program
    {

        static Form1 form;
        static string enterpriseName;
        static int workmans;
        static double paymentPerHour;
        static string bestWorker;
        static int hoursPerMonth;
        static double imposing;
        static string superior;
        static Queue<PersonnelDepartment> queue;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            queue = new Queue<PersonnelDepartment>();
            Application.Run(form);
        }

        public static bool CheckingTBs()
        {
            bool check = true;
            enterpriseName = form.tbEnterpriseName.Text;
            bestWorker = form.tbBestWorker.Text;
            superior = form.tbSuperior.Text;
            Color colorError = Color.FromArgb(255, 200, 198);
            Color colorDefault = Color.White;

            if (!PersonnelDepartment.CheckingEnterpriseName(enterpriseName))
            {
                form.tbEnterpriseName.Text = "";
                form.tbEnterpriseName.BackColor = colorError;
                check = false;
            }
            else form.tbEnterpriseName.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbWorkmans.Text, out workmans) || !PersonnelDepartment.CheckingWorkmans(workmans))
            {
                form.tbWorkmans.Text = "";
                form.tbWorkmans.BackColor = colorError;
                check = false;
            }
            else form.tbWorkmans.BackColor = colorDefault;

            if (!Double.TryParse(form.tbPaymentPerHour.Text, out paymentPerHour) || !PersonnelDepartment.CheckingPaymentPerHour(paymentPerHour))
            {
                form.tbPaymentPerHour.Text = "";
                form.tbPaymentPerHour.BackColor = colorError;
                check = false;
            }
            else form.tbPaymentPerHour.BackColor = colorDefault;

            if (!PersonnelDepartment.CheckingBestWorker(bestWorker))
            {
                form.tbBestWorker.Text = "";
                form.tbBestWorker.BackColor = colorError;
                check = false;
            }
            else form.tbBestWorker.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbHoursPerMonth.Text, out hoursPerMonth) || !PersonnelDepartment.CheckingHoursPerMonth(hoursPerMonth))
            {
                form.tbHoursPerMonth.Text = "";
                form.tbHoursPerMonth.BackColor = colorError;
                check = false;
            }
            else form.tbHoursPerMonth.BackColor = colorDefault;

            if (!Double.TryParse(form.tbImposing.Text, out imposing) || !PersonnelDepartment.CheckingImposing(imposing))
            {
                form.tbImposing.Text = "";
                form.tbImposing.BackColor = colorError;
                check = false;
            }
            else form.tbImposing.BackColor = colorDefault;

            if (!PersonnelDepartment.CheckingSuperior(superior))
            {
                form.tbSuperior.Text = "";
                form.tbSuperior.BackColor = colorError;
                check = false;
            }
            else form.tbSuperior.BackColor = colorDefault;
            return check;
        }

        public static void CreateEnterprise()
        {
            queue.Enqueue(new PersonnelDepartment(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, superior));
        }

        public static void ShowAllDepartments()
        {
            form.tbOutput.Text = null;
            foreach (PersonnelDepartment i in queue)
                form.tbOutput.Text += i.ToString()+"\n";

            TreeView treeView = form.tvOutput;
            treeView.Nodes.Clear();
            treeView.Nodes.Add("Количество объектов: " + PersonnelDepartment.objects);
            foreach (PersonnelDepartment i in queue)
            {
                treeView.Nodes[0].Nodes.Add(i.GetEnterpriseName());
                treeView.Nodes[0].LastNode.Nodes.Add("Лучший работник " + i.GetWorkmans());
                treeView.Nodes[0].LastNode.Nodes.Add("ЗП в час " + i.GetPaymentPerHour());
                treeView.Nodes[0].LastNode.Nodes.Add("Лучший работник " + i.GetBestWorker());
                treeView.Nodes[0].LastNode.Nodes.Add("Рабочих часов в месяц " + i.GetHoursPerMonth());
                treeView.Nodes[0].LastNode.Nodes.Add("Налог " + i.GetImposing());
                treeView.Nodes[0].LastNode.Nodes.Add("Начальник " + i.GetSuperior());
            }
            form.tvOutput = treeView;
        }
    }
}
