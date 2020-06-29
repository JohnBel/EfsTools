using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2769)]
    [Attributes(9)]
    public sealed class Gsm1900AutocalPwrDacF2
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}