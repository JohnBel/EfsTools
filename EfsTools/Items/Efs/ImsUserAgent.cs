using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [NvItemId(69689)]
    [EfsFile("/nv/item_files/ims/ims_user_agent", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsUserAgent
    {
        [JsonIgnore]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        private byte[] _value;

        public string ValueString
        {
            get => StringUtils.GetString(_value);
            set => _value = StringUtils.GetBytes(value, 1024);
        }
    }
}