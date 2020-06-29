using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(35)]
    [Attributes(41)]
    public sealed class CdmaMobileTerminatedForeignSidRegistrationFlag
    {
        public CdmaMobileTerminatedForeignSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }


        [FieldCount(2)]
        public sbyte[] Enabled { get; set; }
    }
}