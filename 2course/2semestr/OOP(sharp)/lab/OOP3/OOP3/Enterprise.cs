namespace OOP3
{
    class Enterprise
    {
        private string _enterpriseName;
        private int _workmans;
        private double _paymentPerHour;
        private string _bestWorker;
        private int _hoursPerMonth;
        private double _imposing;
        private string _superior;
        public static int objects = 0;

        public Enterprise()
        {
            objects++;
            _enterpriseName = "Funcorp";
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }

        public Enterprise(string enterpriseName)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }

        public Enterprise(string enterpriseName, int workmans)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }

        public Enterprise(string enterpriseName,
        int workmans,
        double paymentPerHour,
        string bestWorker,
        int hoursPerMonth,
        double imposing,
        string superior)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = paymentPerHour;
            _bestWorker = bestWorker;
            _hoursPerMonth = hoursPerMonth;
            _imposing = imposing;
            _superior = superior;
        }

        public string GetEnterpriseName()
        {
            return _enterpriseName;
        }

        public int GetWorkmans()
        {
            return _workmans;
        }

        public double GetPaymentPerHour()
        {
            return _paymentPerHour;
        }

        public string GetBestWorker()
        {
            return _bestWorker;
        }

        public int GetHoursPerMonth()
        {
            return _hoursPerMonth;
        }

        public double GetImposing()
        {
            return _imposing;
        }

        public string GetSuperior()
        {
            return _superior;
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
            + "\r\nГлава отделения: " + _superior+ "\r\n\r\n";
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

        public static bool CheckingSuperior(string superior)
        {
            return !(superior.Length == 0);
        }
    }
}
