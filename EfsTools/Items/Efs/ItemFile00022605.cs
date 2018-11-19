using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(68468)]
    [EfsFile("/nv/item_files/rfnv/00022605", true, 0xE1FF)]
    [Attributes(9)]
    public class RfnvTdscdmaBcConfig
    {
        [JsonIgnore]
        [ElementsCount(8)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 8);
        }
    }
}