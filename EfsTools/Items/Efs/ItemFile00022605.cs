using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/rfnv/00022605", true, 0xE1FF)]
	[Attributes(9)]
	public class ItemFile00022605
	{
		public ItemFile00022605()
		{
		}

        [JsonIgnore]
	    [ElementsCount(8)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }

	    public string ValueString
	    {
	        get { return StringUtils.GetString(Value); }
	        set { Value = StringUtils.GetBytes(value, 8); }
	    }
    }
}
