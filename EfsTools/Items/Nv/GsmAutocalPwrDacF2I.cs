using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2766)]
    [Attributes(9)]
    public sealed class GsmAutocalPwrDacF2
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}