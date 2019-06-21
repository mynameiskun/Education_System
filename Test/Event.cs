using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Event
    {
        public void event_action(object sender,EventArgs e)
        {
            Console.WriteLine("this is a event");
        }

    }
}
