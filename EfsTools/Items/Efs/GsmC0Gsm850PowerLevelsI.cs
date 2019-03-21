using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025076", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm850PowerLevelsI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] GsmPowerLevels { get; set; }
        
    }
}
