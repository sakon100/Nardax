using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nardax
{   
    class QueuTester
    {
        


        public QueuTester()
        {
            var _queue = new Queue<string>();
            _queue.Enqueue("a");
            _queue.Enqueue("b");
            _queue.Enqueue("c");
            _queue.Enqueue("d");
            
        }

    }
}
