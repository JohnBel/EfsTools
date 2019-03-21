using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025078", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm1800PowerLevelsI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] GsmPowerLevels { get; set; }
        
    }
}
