using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/nv/item_files/ims/qipcall_audio_codec_list", false, 0x81FF)]
    [Attributes(9)]
    public sealed class QipcallAudioCodecList
    {
        [JsonIgnore]
        [FieldCount(128)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 128);
        }
    }
}