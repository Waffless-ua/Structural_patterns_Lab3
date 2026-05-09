using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite.Iterator
{
    public class DepthFirstIterator : ILightIterator
    {
        private Stack<LightNode> stack = new();

        public DepthFirstIterator(LightNode root)
        {
            stack.Push(root);
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public LightNode Next()
        {
            var current = stack.Pop();

            if (current is LightElementNode element)
            {
                var children = element.Children;

                for (int i = children.Count - 1; i >= 0; i--)
                {
                    stack.Push(children[i]);
                }
            }

            return current;
        }
    }
}
