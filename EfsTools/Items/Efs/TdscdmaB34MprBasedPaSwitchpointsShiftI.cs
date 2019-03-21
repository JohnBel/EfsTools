using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022634", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB34MprBasedPaSwitchpointsShiftI
    {
        [ElementsCount(7)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}
