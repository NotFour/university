using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2
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
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }

        public static bool CheckingTBs()
        {
            bool check = true;
            enterpriseName = form.tbEnterpriseName.Text;
            bestWorker = form.tbBestWorker.Text;
            superior = form.tbSuperior.Text;
            System.Drawing.Color colorError = System.Drawing.Color.FromArgb(255, 200, 198);
            System.Drawing.Color colorDefault = System.Drawing.Color.White;

            if (!Enterprise.CheckingEnterpriseName(enterpriseName))
            {
                form.tbEnterpriseName.Text = "";
                form.tbEnterpriseName.BackColor = colorError;
                check = false;
            }
            else form.tbEnterpriseName.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbWorkmans.Text, out workmans) || !Enterprise.CheckingWorkmans(workmans))
            {
                form.tbWorkmans.Text = "";
                form.tbWorkmans.BackColor = colorError;
                check = false;
            }
            else form.tbWorkmans.BackColor = colorDefault;

            if (!Double.TryParse(form.tbPaymentPerHour.Text, out paymentPerHour) || !Enterprise.CheckingPaymentPerHour(paymentPerHour))
            {
                form.tbPaymentPerHour.Text = "";
                form.tbPaymentPerHour.BackColor = colorError;
                check = false;
            }
            else form.tbPaymentPerHour.BackColor = colorDefault;

            if (!Enterprise.CheckingBestWorker(bestWorker))
            {
                form.tbBestWorker.Text = "";
                form.tbBestWorker.BackColor = colorError;
                check = false;
            }
            else form.tbBestWorker.BackColor = colorDefault;

            if (!Int32.TryParse(form.tbHoursPerMonth.Text, out hoursPerMonth) || !Enterprise.CheckingHoursPerMonth(hoursPerMonth))
            {
                form.tbHoursPerMonth.Text = "";
                form.tbHoursPerMonth.BackColor = colorError;
                check = false;
            }
            else form.tbHoursPerMonth.BackColor = colorDefault;

            if (!Double.TryParse(form.tbImposing.Text, out imposing) || !Enterprise.CheckingImposing(imposing))
            {
                form.tbImposing.Text = "";
                form.tbImposing.BackColor = colorError;
                check = false;
            }
            else form.tbImposing.BackColor = colorDefault;

            if (!Enterprise.CheckingSuperior(superior))
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
            form.tbOutput.Text = new Enterprise(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, superior).ToString();
        }
    }
}
