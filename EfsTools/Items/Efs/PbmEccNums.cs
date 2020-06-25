using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/pbm/pbm_ecc_nums", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class PbmEccNums
    {
        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 480)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetStringWithZero(Value);
            set => Value = StringUtils.GetBytesWithZero(value, 480);
        }
    }
}