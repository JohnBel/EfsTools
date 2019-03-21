using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025083", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1900PowerLevelsI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] GsmPowerLevels { get; set; }
        
    }
}
