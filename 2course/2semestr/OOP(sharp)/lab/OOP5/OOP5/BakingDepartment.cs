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
            return "Объектов класса " + objects 
            + "Организация: " + _enterpriseName
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
            _bakingPerMonth = 1000;
            _enterpriseName = "Funcorp";
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }
    }
}
