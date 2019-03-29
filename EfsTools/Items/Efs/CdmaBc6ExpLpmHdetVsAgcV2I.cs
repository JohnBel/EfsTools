using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020686", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaBc6ExpLpmHdetVsAgcV2
    {
        [ElementsCount(17)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}
