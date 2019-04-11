using ClassLibrary1_CVK;
using ClassLibrary1_CVK.Model;
using Project1_Train_CVK_Scrapper.Setting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Project1_Train_CVK_Scrapper
{
    class Program
    {
        static List<Region> regions = new List<Region>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            retrieveCVK();

            updateCVK();

            Console.WriteLine("End");
            Console.ReadLine();
        }

        public static void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            retrieveCVK();
        }

        public static void retrieveCVK()
        {
            regions = RetrieveHtml.getHtmlHref();

            CVK cvk = new CVK(regions);

            JsonStorage ex = new JsonStorage();
            ex.upsert(cvk);

            Console.WriteLine("Update will in 3 minutes");
        }

        public static void updateCVK()
        {
            Timer timer = new Timer();
            timer.Interval = 150000;
            timer.Elapsed += TimerOnElapsed;
            timer.Start();
        }


    }
}
