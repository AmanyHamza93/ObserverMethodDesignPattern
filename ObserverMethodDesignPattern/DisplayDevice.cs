using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMethodDesignPattern
{
    public class DisplayDevice: IObserver
    {
        public string _device;
        public DisplayDevice(string device)
        {
            _device = device;
        }
        public void Update(string currentWeather)
        {
            Console.WriteLine($"weather display at {_device} and weather is {currentWeather}");
        }
    }
}
