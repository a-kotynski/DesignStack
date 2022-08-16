using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStack
{
    public class Stack
    {
        public List<object> StackList { get; set; }
        public void Push(object obj)
        {
            try
            {
                StackList.Add(obj);
            }
            catch (InvalidOperationException)
            {

                throw;
            }
        }
        public object Pop()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (InvalidOperationException)
            {

                throw;
            }
        }
        public void Clear()
        {
            StackList.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
