using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4954)]
    [Attributes(9)]
    public sealed class XoFactoryCalibration
    {
        public int C3 { get; set; }


        public int C2 { get; set; }


        public int C1 { get; set; }


        public int C0 { get; set; }


        public int T0 { get; set; }


        public int T0p { get; set; }


        public int P { get; set; }


        public ushort FtQualInd { get; set; }


        public byte XoTrim { get; set; }
    }
}