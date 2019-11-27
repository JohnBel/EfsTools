using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Efs;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    public enum IWlanAuthModeValues : byte
    {
        Uac = 0,
        Uas = 1,
        None = 2
    }

    [Serializable]
    [NvItemId(5828)]
    [Attributes(9)]
    public class IWlanAuthMode
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        public string ValueString
        {
            get => $"{(IWlanAuthModeValues)Value}";
            set => Value =
                EnumUtils.ParseEnumByte(typeof(IWlanAuthModeValues), value);
        }
    }
}