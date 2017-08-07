using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            RadioClock useRadio = new RadioClock();
            useRadio.turnOn();
            useRadio.getTime();
            useRadio.radioStation();
            
            Console.ReadLine();
           

        }
    }
}