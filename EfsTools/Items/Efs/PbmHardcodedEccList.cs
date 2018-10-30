using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/pbm/pbm_hardcoded_ecc_list", true, 0xE1FF)]
    [Attributes(9)]
    public class PbmHardcodedEccList
    {
        [JsonIgnore]
        [ElementsCount(350)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetStringWithZero(Value);
            set => Value = StringUtils.GetBytesWithZero(value, 350);
        }
    }
}