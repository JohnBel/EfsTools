using System;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6844)]
    [Attributes(9)]
    public sealed class EnhancedHplmnSrchTbl
    {
        [JsonIgnore]
        [FieldCount(100)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 100);
        }
    }
}