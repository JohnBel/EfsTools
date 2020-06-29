using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2742)]
    [Attributes(9)]
    public sealed class GsmAutocalPwrDacF1
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}