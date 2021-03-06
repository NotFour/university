﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace OOP3
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
        static Queue<Enterprise> queue;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            queue = new Queue<Enterprise>();
            additionalTask();
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

        public static void additionalTask()
        { 
            const int elements = 100000;

            Queue<Enterprise> testQueue = new Queue<Enterprise>();
            Enterprise[] testArray = new Enterprise[elements];
            Enterprise testElement = new Enterprise();
            for (int i = 0; i < elements; i++)
            {
                testQueue.Enqueue(testElement);
                testArray[i] = testElement;
            }

            Stopwatch stopWatch = new Stopwatch();

            ListViewItem[] listViewItems = new ListViewItem[4];
            for (int i = 0; i < listViewItems.Length; i++)
            {
                listViewItems[i] = new ListViewItem();
            }

            stopWatch.Start();
            foreach (Enterprise enterprise in testQueue)
            {
                testElement = enterprise;
            }
            stopWatch.Stop();
            listViewItems[0].Text = "Выборка из коллекции за " + stopWatch.Elapsed.Ticks + " тиков.";
            stopWatch.Reset();
            
            stopWatch.Start();
            for (int i = 0; i < elements; i++)
            {
                testElement = testArray[i];
            }
            stopWatch.Stop();
            listViewItems[1].Text = "Выборка из массива за " + stopWatch.Elapsed.Ticks + " тиков.";
            stopWatch.Reset();

            Random random = new Random();

            stopWatch.Start();
            for (int i = 0; i < elements; i++)
            {
                int index = random.Next(elements);
                foreach (Enterprise enterprise in testQueue)
                {
                    if (index <= 0)
                    {
                        testElement = enterprise;
                        break;
                    }
                    index--;
                }
            }
            stopWatch.Stop();
            listViewItems[2].Text = "Случайная выборка из очереди за " + stopWatch.Elapsed.Ticks + " тиков.";
            stopWatch.Reset();
            
            stopWatch.Start();
            for (int i = 0; i < elements; i++)
            {
                int index = random.Next(elements);
                testElement = testArray[index];
            }
            stopWatch.Stop();
            listViewItems[3].Text = "Случайная выборка из массива за " + stopWatch.Elapsed.Ticks + " тиков.";
            
            form.listComparison.Items.AddRange(listViewItems);
        }

        public static void CreateEnterprise()
        {
            queue.Enqueue(new Enterprise(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, superior));
        }

        public static void ShowAllEnterprises()
        {
            form.tbOutput.Text = null;
            foreach (Enterprise i in queue)
                form.tbOutput.Text += i.ToString()+"\n";
        }
    }
}
