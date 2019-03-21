using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxSmpsPdmDataType
    {
        [ElementsCount(6)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] CalSmpsPdmTbl { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] GsmSmpsPdmTbl { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] EdgeSmpsPdmTbl { get; set; }
        
    }
}
