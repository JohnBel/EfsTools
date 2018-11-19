using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(34)]
    [Attributes(41)]
    public class CdmaMobileTerminatedHomeSidRegistrationFlag
    {
        public CdmaMobileTerminatedHomeSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Name { get; set; }


        [ElementsCount(2)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Enabled { get; set; }
    }
}