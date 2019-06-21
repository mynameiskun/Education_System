using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace Test
{
    public delegate void TimerChange();

    public class Delegat
    {

        
        public static void tmchange()
        {
            Event e = new Event();
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 120;
            timer.Elapsed += new ElapsedEventHandler(e.event_action);

        }
    }
}
