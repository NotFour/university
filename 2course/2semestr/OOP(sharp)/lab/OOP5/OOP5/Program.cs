using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP5
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
        static int bakingPerMonth;
        static MyQueue queue;
        static Random random = new Random();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            queue = new MyQueue();
            additionalTask();
            Application.Run(form);

        }

        public static void additionalTask() 
        {
            System.Threading.TimerCallback timerCallback = new System.Threading.TimerCallback((object obj) => 
            {
                queue = queue+(new PersonnelDepartment("predp" + random.Next(100), random.Next(100)));
                ShowAllEnterprises();
            });
            System.Threading.Timer timer = new System.Threading.Timer(timerCallback, 0, 5000, 5000);
          
        }

        public static bool CheckingTBsPersonnelDepartment()
        {
            bool check = true;
            enterpriseName = form.tbEnterpriseName.Text;
            bestWorker = form.tbBestWorker.Text;
            superior = form.tbSuperior.Text;
            System.Drawing.Color colorError = System.Drawing.Color.FromArgb(255, 200, 198);
            System.Drawing.Color colorDefault = System.Drawing.Color.White;

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

        public static bool CheckingTBsBakingDepartment()
        {
            bool check = true;
            enterpriseName = form.tbEnterpriseName2.Text;
            bestWorker = form.tbBestWorker2.Text;
            System.Drawing.Color colorError = System.Drawing.Color.FromArgb(255, 200, 198);
            System.Drawing.Color colorDefault = System.Drawing.Color.White;

            if (!BakingDepartment.CheckingEnterpriseName(enterpriseName))
            {
                form.tbEnterpriseName2.Text = "";
                form.tbEnterpriseName2.BackColor = colorError;
                check = false;
            }
            else form.tbEnterpriseName2.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbWorkmans2.Text, out workmans) || !BakingDepartment.CheckingWorkmans(workmans))
            {
                form.tbWorkmans2.Text = "";
                form.tbWorkmans2.BackColor = colorError;
                check = false;
            }
            else form.tbWorkmans2.BackColor = colorDefault;

            if (!Double.TryParse(form.tbPayment2.Text, out paymentPerHour) || !BakingDepartment.CheckingPaymentPerHour(paymentPerHour))
            {
                form.tbPayment2.Text = "";
                form.tbPayment2.BackColor = colorError;
                check = false;
            }
            else form.tbPayment2.BackColor = colorDefault;

            if (!BakingDepartment.CheckingBestWorker(bestWorker))
            {
                form.tbBestWorker2.Text = "";
                form.tbBestWorker2.BackColor = colorError;
                check = false;
            }
            else form.tbBestWorker2.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbHoursPerMonth2.Text, out hoursPerMonth) || !BakingDepartment.CheckingHoursPerMonth(hoursPerMonth))
            {
                form.tbHoursPerMonth2.Text = "";
                form.tbHoursPerMonth2.BackColor = colorError;
                check = false;
            }
            else form.tbHoursPerMonth2.BackColor = colorDefault;

            if (!Double.TryParse(form.tbImposing2.Text, out imposing) || !BakingDepartment.CheckingImposing(imposing))
            {
                form.tbImposing2.Text = "";
                form.tbImposing2.BackColor = colorError;
                check = false;
            }
            else form.tbImposing2.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbBakingPerMonth.Text, out bakingPerMonth) || !BakingDepartment.CheckingBakingPerMonth(bakingPerMonth))
            {
                form.tbBakingPerMonth.Text = "";
                form.tbBakingPerMonth.BackColor = colorError;
                check = false;
            }
            else form.tbBakingPerMonth.BackColor = colorDefault;
            return check;
        }

        public static void CreatePersonnelDepartment()
        {
            queue = queue+(new PersonnelDepartment(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, superior));
        }

        public static void CreateBakingDepartment()
        {
            queue = queue+(new BakingDepartment(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, bakingPerMonth));
        }

        public static void ShowAllEnterprises()
        {
            form.tbOutput.Text = null;
            foreach (Department i in queue)
                form.tbOutput.Text += i.ToString() + "\n";
        }
    }
}
