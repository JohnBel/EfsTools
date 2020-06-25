using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6844)]
    [Attributes(9)]
    public sealed class EnhancedHplmnSrchTbl
    {
        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 100);
        }
    }
}