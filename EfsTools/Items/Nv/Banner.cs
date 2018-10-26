using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(71)]
	[Attributes(9)]
	public class Banner
    {
		public Banner()
		{
		}

        [JsonIgnore]
	    [ElementsCount(13)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }

	    public string ValueString
	    {
	        get { return StringUtils.GetString(Value); }
	        set { Value = StringUtils.GetBytes(value, 13); }
	    }
    }
}
