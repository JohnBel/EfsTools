using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025060", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm850MultislotMaxTxPwrI
    {
        [ElementsCount(5)]
        [ElementType("int16")]
        [Description("")]
        public short[] GsmMultislotTxPwrGmsk { get; set; }
        
        [ElementsCount(5)]
        [ElementType("int16")]
        [Description("")]
        public short[] GsmMultislotTxPwr8psk { get; set; }
        
    }
}
