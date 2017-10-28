using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class MyQueue : Queue<Department>
    {
        public static MyQueue operator +(MyQueue queue, Department dep)
        {
            queue.Enqueue(dep);
            return queue;
        }

        public static MyQueue operator -(MyQueue queue)
        {
            queue.Dequeue();
            return queue;
        }
    }
}
