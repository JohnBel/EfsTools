using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(910)]
    [Attributes(9)]
    public sealed class PppUserId
    {
        public byte Length { get; set; }


        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 127)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 127);
        }
    }
}