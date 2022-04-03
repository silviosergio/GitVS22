using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitVS22
{
    public class Rod
    {
        private readonly string label;
        private Stack<int> stack;

        public Rod(string label, Stack<int> stack)
        {
            this.label = label;
            this.stack = stack;
        }

        public string Label { get => label; }
        public void Push(int disk) => stack.Push(disk);
        public int Pop() => stack.Pop();
    }
}
