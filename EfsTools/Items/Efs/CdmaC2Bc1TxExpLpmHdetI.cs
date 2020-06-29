using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023744", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxExpLpmHdet
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [FieldCount(16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }
}