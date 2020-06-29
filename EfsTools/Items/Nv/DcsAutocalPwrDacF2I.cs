using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2767)]
    [Attributes(9)]
    public sealed class DcsAutocalPwrDacF2
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}