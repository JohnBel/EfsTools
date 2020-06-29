using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Utils;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/additional_dial_string", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AdditionalDialString
    {
        private byte[] _value1;


        public byte[] _value2;

        public string Value1String
        {
            get => StringUtils.GetString(_value1);
            set => _value1 = StringUtils.GetBytes(value, 20);
        }

        public string Value2String
        {
            get => StringUtils.GetString(_value2);
            set => _value2 = StringUtils.GetBytes(value, 20);
        }
    }
}