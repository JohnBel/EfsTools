using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_audio_codec_list", false, 0x81FF)]
	[Attributes(9)]
	public class QipcallAudioCodecList
    {
		public QipcallAudioCodecList()
		{
		}

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get { return StringUtils.GetString(Value); }
            set { Value = StringUtils.GetBytes(value, 128); }
        }
    }
}
