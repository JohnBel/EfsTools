using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023223", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc5TxPwrTempComp
    {
        public sbyte Reserved { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa0PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa0PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa1PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa1PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa2PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa2PowerSlope { get; set; }

        [FieldCount(8)]
        public sbyte[] Pa3PowerOffset { get; set; }

        [FieldCount(8)]
        public short[] Pa3PowerSlope { get; set; }
    }
}