using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class dfMarkupElement
{
    public dfMarkupElement()
    {
        this.ChildNodes = new System.Collections.Generic.List<dfMarkupElement>();
    }

    protected abstract void _PerformLayoutImpl(dfMarkupBox container, dfMarkupStyle style);
    public void AddChildNode(dfMarkupElement node)
    {
        node.Parent = this;
        this.ChildNodes.Add(node);
    }

    public void PerformLayout(dfMarkupBox container, dfMarkupStyle style)
    {
        this._PerformLayoutImpl(container, style);
    }

    internal virtual void Release()
    {
        this.Parent = null;
        this.ChildNodes.Clear();
    }

    protected System.Collections.Generic.List<dfMarkupElement> ChildNodes { get; private set; }

    public dfMarkupElement Parent { get; protected set; }
}

