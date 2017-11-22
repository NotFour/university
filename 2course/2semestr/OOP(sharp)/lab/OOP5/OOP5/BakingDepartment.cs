using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class BakingDepartment : Department
    {

        public static int objects = 0;

        int _bakingPerMonth;

        public override string ToString()
        {
            return "Объектов класса BakingDepartment " + objects
            + "\r\nОрганизация: " + _enterpriseName
            + "\r\nКол-во работников: " + _workmans
            + "\r\nПлата в час: " + _paymentPerHour
            + "\r\nЛучший работник: " + _bestWorker
            + "\r\nРабочих часов в месяц: " + _hoursPerMonth
            + "\r\nНалог: " + _imposing
            + "\r\nВыпечки в месяц: " + _bakingPerMonth + "\r\n\r\n";
        }

        public BakingDepartment()
        {
            objects++;
            _enterpriseName = "Funcorp";
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _bakingPerMonth = 1000;
        }

        public BakingDepartment(string enterpriseName,
        int workmans,
        double paymentPerHour,
        string bestWorker,
        int hoursPerMonth,
        double imposing,
        int bakingPerMonth)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = paymentPerHour;
            _bestWorker = bestWorker;
            _hoursPerMonth = hoursPerMonth;
            _imposing = imposing;
            _bakingPerMonth = bakingPerMonth;
        }

        public void SetBakingPerMonth(int bakingPerMonth)
        {
            _bakingPerMonth = bakingPerMonth;
        }

        public int GetBakingPerMonth()
        {
            return _bakingPerMonth;
        }

        public static bool CheckingBakingPerMonth(int bakingPerMonth)
        {
            return !(bakingPerMonth <= 0);
        }
    }
}
