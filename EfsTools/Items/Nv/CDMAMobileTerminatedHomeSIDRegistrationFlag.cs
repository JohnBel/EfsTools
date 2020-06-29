using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(34)]
    [Attributes(41)]
    public sealed class CdmaMobileTerminatedHomeSidRegistrationFlag
    {
        public CdmaMobileTerminatedHomeSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }

        [FieldCount(2)]
        public sbyte[] Enabled { get; set; }
    }
}