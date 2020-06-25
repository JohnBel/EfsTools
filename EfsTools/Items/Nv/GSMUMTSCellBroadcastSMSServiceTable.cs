using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1014)]
    [Attributes(41)]
    public sealed class GsmUmtsCellBroadcastSmsServiceTable
    {
        public byte Index { get; set; }


        public byte ActiveService { get; set; }


        public ushort ServiceFrom { get; set; }


        public ushort ServiceTo { get; set; }


        public byte Selected { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public byte[] Label { get; set; }

        public string LabelString
        {
            get => StringUtils.GetString(Label);
            set => Label = StringUtils.GetBytes(value, 30);
        }


        public byte LabelEncoding { get; set; }


        public byte BcAlert { get; set; }


        public byte MaxMessages { get; set; }
    }
}