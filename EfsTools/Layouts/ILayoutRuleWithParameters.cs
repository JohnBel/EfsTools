using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Layouts
{
    internal interface ILayoutRuleWithParameters : ILayoutRule
    {
        Dictionary<string, string> Parameters { get; }
    }
}
