using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025624", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma2100TxLinVsTempVsFreqPOut
    {
        public byte Reserved { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }
}