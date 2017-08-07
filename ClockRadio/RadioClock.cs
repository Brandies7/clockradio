using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class RadioClock
    {
        public double time;
        public string isOn;
        public double station;

        public RadioClock()
        {

        }

        public double getTime()
        {
            Console.WriteLine("Enter alarm time");
            time = Convert.ToDouble(Console.ReadLine());
            return time;
        }

        public void turnOn()
        {
            Console.WriteLine("Turn alarm on: 'yes' or 'no'");
            isOn = Console.ReadLine();
        }

        public double radioStation()
        {
            Console.WriteLine("What station would you like to listen to?");
            station = Convert.ToDouble(Console.ReadLine());
            return station;
        }

    }    
    
}





    

