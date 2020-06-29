using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023738", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc5HdrTxPwrLimData
    {
        [FieldCount(25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit { get; set; }
    }
}