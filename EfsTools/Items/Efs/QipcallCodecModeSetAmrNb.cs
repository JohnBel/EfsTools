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
    [EfsFile("/nv/item_files/ims/qipcall_codec_mode_set", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallCodecModeSetAmrNb
    {
        /*
          0x1 -- 4.75 kbps \n
        - 0x2 -- 5.15 kbps \n
        - 0x4 -- 5.9 kbps \n
        - 0x8 -- 6.17 kbps \n
        - 0x10 -- 7.4 kbps \n
        - 0x20 -- 7.95 kbps \n
        - 0x40 -- 10.2 kbps \n
        - 0x80 -- 12.2 kbps
         */

        [JsonIgnore]
        public uint Value { get; set; }

        public bool Enable_4_75kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 0);
            set => Value = BitsUtils.SetBitAsBool(Value, 0, value);
        }

        public bool Enable_5_15kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 1);
            set => Value = BitsUtils.SetBitAsBool(Value, 1, value);
        }

        public bool Enable_5_9kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 2);
            set => Value = BitsUtils.SetBitAsBool(Value, 2, value);
        }

        public bool Enable_6_17kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 3);
            set => Value = BitsUtils.SetBitAsBool(Value, 3, value);
        }

        public bool Enable_7_4kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 4);
            set => Value = BitsUtils.SetBitAsBool(Value, 4, value);
        }

        public bool Enable_7_95kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 5);
            set => Value = BitsUtils.SetBitAsBool(Value, 5, value);
        }

        public bool Enable_10_2kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 6);
            set => Value = BitsUtils.SetBitAsBool(Value, 6, value);
        }

        public bool Enable_12_2kbps
        {
            get => BitsUtils.GetBitAsBool(Value, 7);
            set => Value = BitsUtils.SetBitAsBool(Value, 7, value);
        }
    }
}