using System;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(906)]
    [Attributes(9)]
    public sealed class IpPppPassword
    {
        public byte Length { get; set; }


        [JsonIgnore]
        [FieldCount(127)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 127);
        }
    }
}