using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(36)]
    [Attributes(41)]
    public sealed class CdmaMobileTerminatedForeignNidRegistrationFlag
    {
        public CdmaMobileTerminatedForeignNidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }


        [FieldCount(2)]
        public sbyte[] Enabled { get; set; }
    }
}