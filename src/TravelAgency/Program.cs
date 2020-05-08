using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models;

namespace TravelAgency
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VisitEasy store = new VisitEasy();
            store.FillTestData(100);
            store.Save();
            store.Orders.Clear();
            store.Load();
            Console.WriteLine(store.Orders[0].Portions[0].Trip.Location);
            store.Save();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            
        }
    }
}
