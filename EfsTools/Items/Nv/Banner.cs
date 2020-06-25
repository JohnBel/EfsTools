using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(71)]
    [Attributes(9)]
    public sealed class Banner
    {
        [JsonIgnore] [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
        private byte[] _value;

        public string ValueString
        {
            get => StringUtils.GetString(_value);
            set => _value = StringUtils.GetBytes(value, 13);
        }
    }
}