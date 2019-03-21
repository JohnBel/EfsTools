using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmEnhtempcompTempType
    {
        [ElementsCount(16)]
        //[ElementType("GSM_EnhTempComp_pcl_type")]
        [Description("")]
        public GsmEnhtempcompPclType[] TempBin { get; set; }
        
    }
}
