using System.Collections.Generic;

namespace EfsTools.Layouts
{
    internal interface ILayoutRuleWithParameters : ILayoutRule
    {
        Dictionary<string, string> Parameters { get; }
    }
}