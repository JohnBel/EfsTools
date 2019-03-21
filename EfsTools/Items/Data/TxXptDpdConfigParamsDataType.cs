using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class TxXptDpdConfigParamsDataType
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint XptConfig { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint ExpScale { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint SearchCenter { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint SearchWidth { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint QFactor { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TxLinMag { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint PmOrder { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint EptEnvScaleUnity { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint IqGainUnity { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelMaxPower { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelOffsetLow0 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelOffsetLow1 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelOffsetLow2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelOffsetHigh0 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelOffsetHigh1 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RgiSelOffsetHigh2 { get; set; }
        
        [ElementsCount(7)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Reserved2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint EtEnvScaleUnity { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved3 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved4 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved5 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved6 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved7 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved8 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved9 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Reserved10 { get; set; }
        
    }
}
