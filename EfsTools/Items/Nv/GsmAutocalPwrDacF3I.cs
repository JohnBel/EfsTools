using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3146)]
    [Attributes(9)]
    public sealed class GsmAutocalPwrDacF3
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}