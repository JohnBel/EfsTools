using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/mmode_1xsxlte_optimization", false, 0x81FF)]
    [Attributes(9)]
    public class Mmode1xsxLteOptimization
    {
        [ElementsCount(51)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}