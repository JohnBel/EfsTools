using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(71)]
    [Attributes(9)]
    public sealed class Banner
    {
        [JsonIgnore] [FieldCount(13)]
        private byte[] _value;

        public string ValueString
        {
            get => StringUtils.GetString(_value);
            set => _value = StringUtils.GetBytes(value, 13);
        }
    }
}