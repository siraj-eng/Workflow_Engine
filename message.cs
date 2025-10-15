using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class message: Iactivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to the video owner...");
        }
    }
}
