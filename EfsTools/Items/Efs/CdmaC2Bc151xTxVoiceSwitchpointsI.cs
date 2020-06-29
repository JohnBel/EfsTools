using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022103", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc151xTxVoiceSwitchpoints
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }
}