using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2746)]
    [Attributes(9)]
    public sealed class Gsm850AutocalPwrDacF1
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}