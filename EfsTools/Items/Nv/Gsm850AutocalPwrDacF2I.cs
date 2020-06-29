using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2768)]
    [Attributes(9)]
    public sealed class Gsm850AutocalPwrDacF2
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}