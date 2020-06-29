using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(889)]
    [Attributes(41)]
    public sealed class DataServicesMobileIpDmuMnAuthentication
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public sbyte Field3 { get; set; }


        public byte Field4 { get; set; }
    }
}