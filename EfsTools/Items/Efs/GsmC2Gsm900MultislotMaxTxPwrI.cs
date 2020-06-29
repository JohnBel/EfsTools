using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025065", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm900MultislotMaxTxPwr
    {
        [FieldCount(5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [FieldCount(5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }
}