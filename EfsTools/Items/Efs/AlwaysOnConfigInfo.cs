using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/always_on_config_info", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AlwaysOnConfigInfo
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public uint Field3 { get; set; }


        public byte Field4 { get; set; }


        public byte Field5 { get; set; }


        public byte Field6 { get; set; }


        public uint Field7 { get; set; }
    }
}