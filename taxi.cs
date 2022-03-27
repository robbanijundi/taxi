using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        private string OnDutyYN()
        {
            return OnDuty ? "Yes" : "No";
        }

        public void TaxiInfo()
        {
            Console.WriteLine("driver name: {0}", DriverName);
            Console.WriteLine("on duty: {0}", OnDutyYN());
            Console.WriteLine("number of passenger: {0}", NumPassenger);
        }
        public void PickupPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }

    }
}