using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3148)]
    [Attributes(9)]
    public sealed class Gsm850AutocalPwrDacF3
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}