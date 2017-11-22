using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class BakingDepartment : Department
    {
        public static int objects = 0;
        protected int _bakingPerMonth;

        public BakingDepartment(string enterpriseName,
        int workmans,
        double paymentPerHour,
        string bestWorker,
        int hoursPerMonth,
        double imposing,
        int bakingPerMonth,
        string superior)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = paymentPerHour;
            _bestWorker = bestWorker;
            _hoursPerMonth = hoursPerMonth;
            _imposing = imposing;
            _bakingPerMonth = bakingPerMonth;
            _superior = superior;
        }

        public override string ToString()
        {
            return  "Объектов класса" + objects
            + "\r\nОрганизация: " + _enterpriseName
            + "\r\nКол-во работников: " + _workmans
            + "\r\nПлата в час: " + _paymentPerHour
            + "\r\nЛучший работник: " + _bestWorker
            + "\r\nРабочих часов в месяц: " + _hoursPerMonth
            + "\r\nНалог: " + _imposing
            + "\r\nВыпечки в месяц, кг: " + _bakingPerMonth
            + "\r\nГлава отделения: " + _superior + "\r\n\r\n";
        }

        public static bool CheckingEnterpriseName(string enterpriseName)
        {
            return !(enterpriseName.Length == 0);
        }

        public static bool CheckingWorkmans(int workmans)
        {
            return !(workmans <= 0);
        }

        public static bool CheckingPaymentPerHour(double paymentPerHour)
        {
            return !(paymentPerHour <= 0);
        }

        public static bool CheckingBestWorker(string bestWorker)
        {
            return !(bestWorker.Length == 0);
        }

        public static bool CheckingHoursPerMonth(int hoursPerMonth)
        {
            return !(hoursPerMonth <= 0);
        }

        public static bool CheckingImposing(double imposing)
        {
            return !(imposing <= 0);
        }

        public static bool CheckingBakingPerMonth(double bakingPerMonth)
        {
            return !(bakingPerMonth <= 0);
        }

        public static bool CheckingSuperior(string superior)
        {
            return !(superior.Length == 0);
        }
    }
}
