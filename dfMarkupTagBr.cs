﻿using System;

[dfMarkupTagInfo("br")]
public class dfMarkupTagBr : dfMarkupTag
{
    public dfMarkupTagBr() : base("br")
    {
        this.IsClosedTag = true;
    }

    public dfMarkupTagBr(dfMarkupTag original) : base(original)
    {
        this.IsClosedTag = true;
    }

    protected override void _PerformLayoutImpl(dfMarkupBox container, dfMarkupStyle style)
    {
        container.AddLineBreak();
    }
}

