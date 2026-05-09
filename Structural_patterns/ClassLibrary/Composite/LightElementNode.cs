using ClassLibrary.Composite.State;
using ClassLibrary.Composite.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private bool isSelfClosing;
        private NodeState _state;

        private List<string> classes = new List<string>();
        private List<LightNode> children = new List<LightNode>();
        public IReadOnlyList<LightNode> Children => children;

        public LightElementNode(string tagName, bool isSelfClosing, NodeState state)
        {
            this.tagName = tagName;
            this.isSelfClosing = isSelfClosing;
            SetState(state);
        }
        public void SetState(NodeState newState)
        {
            newState.SetContext(this);
            _state = newState;
        }
        public string Render()
        {
            return _state.Render();
        }

        public void AddClass(string className)
        {
            classes.Add(className);
        }

        public void AddChild(LightNode node)
        {
            children.Add(node);
        }

        public int ChildCount()
        {
            return children.Count;
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var child in children)
            {
                sb.Append(child.OuterHTML());
            }

            return sb.ToString();
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<" + tagName);

            if (classes.Count > 0)
            {
                sb.Append(" class=\"");
                sb.Append(string.Join(" ", classes));
                sb.Append("\"");
            }

            if (isSelfClosing)
            {
                sb.Append(" />");
                return sb.ToString();
            }

            sb.Append(">");
            sb.Append(InnerHTML());
            sb.Append("</" + tagName + ">");

            return sb.ToString();
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (var child in children)
            {
                child.Accept(visitor);
            }
        }

        public void RemoveChild(LightNode node)
        {
            children.Remove(node);
        }

        internal void RemoveClass(string className)
        {
            classes.Remove(className);
        }
    }
}
