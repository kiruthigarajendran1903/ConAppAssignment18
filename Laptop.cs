using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    
    internal class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public bool isConnect;
        public string dis;
        public int min;
        int charge = 0;


        public string display { get; set; }
        public bool IsConnect { get; set; }
        public int Min { get; set; }

        public Laptop()
        {
            IsConnect = true;
            charge = 0;

        }
        public bool Connect()
        {
            isConnect = true;
            return isConnect;
        }



        public int Recharge(int min)
        {
            

            charge += min / 10; // Assuming 10 minutes charge increases battery by 1%
            if (charge > 100)
            {
                return charge = 100;
            }
            else
            {
                return charge;
            }
        }

        public string Display()
        {
            return $"IsConnected: {isConnect}\t Mobile Chrage:{charge}%";
        }
    }
}
