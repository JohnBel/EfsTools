using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1877)]
	[Attributes(9)]
	public class RfBandConfiguration
    {
		public RfBandConfiguration()
		{
		}
		
        
		[ElementsCount(8)]
		[ElementType("int8")]
		[Description("")]
		public byte[] Value { get; set; }

	    /*public string ValueString
        {
	        get { return StringUtils.GetStringWithZero(Value); }
	        set { Value = StringUtils.GetBytesWithZero(value, 8); }
	    }*/
    }
}
