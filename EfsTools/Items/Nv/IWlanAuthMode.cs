using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5828)]
    [Attributes(9)]
    public sealed class IWlanAuthMode
    {
        [JsonIgnore]
        public byte Value { get; set; }

        public string ValueString
        {
            get => $"{(IWlanAuthModeValues) Value}";
            set =>
                Value =
                    EnumUtils.ParseEnumByte(typeof(IWlanAuthModeValues), value);
        }
    }
}