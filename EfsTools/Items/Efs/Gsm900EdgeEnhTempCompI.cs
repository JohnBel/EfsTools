using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024603", true, 0xE1FF)]
    [Attributes(9)]
    public class Gsm900EdgeEnhTempComp
    {
        [ElementsCount(1)]
        [ElementType("GSM_EnhTempComp_temp_type")]
        [Description("")]
        public GsmEnhtempcompTempType Value { get; set; }
        
    }
}
