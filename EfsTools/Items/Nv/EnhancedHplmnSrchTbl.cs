using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(6844)]
	[Attributes(9)]
	public class EnhancedHplmnSrchTbl
    {
		public EnhancedHplmnSrchTbl()
		{
		}
		
        [JsonIgnore]
		[ElementsCount(100)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }

	    public string ValueString
	    {
	        get { return StringUtils.GetString(Value); }
	        set { Value = StringUtils.GetBytes(value, 100); }
	    }
    }
}
