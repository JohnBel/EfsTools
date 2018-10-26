using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/lte/ML1/update_band_range", true, 0xE1FF)]
	[Attributes(9)]
	public class UpdateBandRange
	{
		public UpdateBandRange()
		{
		}

	    [JsonIgnore]
	    [ElementsCount(20)]
		[ElementType("int8")]
		[Description("")]
		public byte[] Value { get; set; }

	    public string ValueString
	    {
	        get { return StringUtils.GetString(Value); }
	        set { Value = StringUtils.GetBytes(value, 20); }
	    }
    }
}
