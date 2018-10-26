using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/ims/ims_user_agent", false, 0x81FF)]
	[Attributes(9)]
	public class ImsUserAgent
    {
		public ImsUserAgent()
		{
		}

        [JsonIgnore]
        [ElementsCount(1024)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get { return StringUtils.GetString(Value); }
            set { Value = StringUtils.GetBytes(value, 1024); }
        }
    }
}
