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
    [Subscription]
    [EfsFile("/nv/item_files/ims/qipcall_codec_mode_set_amr_wb", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallCodecModeSetAmrWb
    {
        /*
         - 0x1 - 6.60 kbps \n
        - 0x2 - 8.85 kbps \n
        - 0x4 - 12.65 kbps \n
        - 0x8 - 14.25 kbps \n
        - 0x10 - 15.85 kbps \n
        - 0x20 - 18.25 kbps \n
        - 0x40 - 19.85 kbps \n 
        - 0x80 - 23.05 kbps \n
        - 0x100 - 23.85 kbps
        */
        [JsonIgnore]
        public uint Value { get; set; }

        public bool Enable_6_60kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 0);
            set => Value = BitsUtils.SetBitAsBool(Value, 0, value);
        }

        public bool Enable_8_85kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 1);
            set => Value = BitsUtils.SetBitAsBool(Value, 1, value);
        }

        public bool Enable_12_65kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 2);
            set => Value = BitsUtils.SetBitAsBool(Value, 2, value);
        }

        public bool Enable_14_25kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 3);
            set => Value = BitsUtils.SetBitAsBool(Value, 3, value);
        }

        public bool Enable_15_85kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 4);
            set => Value = BitsUtils.SetBitAsBool(Value, 4, value);
        }

        public bool Enable_18_25kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 5);
            set => Value = BitsUtils.SetBitAsBool(Value, 5, value);
        }

        public bool Enable_19_85kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 6);
            set => Value = BitsUtils.SetBitAsBool(Value, 6, value);
        }

        public bool Enable_23_05kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 7);
            set => Value = BitsUtils.SetBitAsBool(Value, 7, value);
        }

        public bool Enable_23_85kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 8);
            set => Value = BitsUtils.SetBitAsBool(Value, 8, value);
        }
    }
}