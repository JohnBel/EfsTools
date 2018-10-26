using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/nas/tdscdma_op_plmn_list", true, 0xE1FF)]
	[Attributes(9)]
	public class TdscdmaOpPlmnList
	{
		public TdscdmaOpPlmnList()
		{
		}

        [JsonIgnore]
	    [ElementsCount(61)]
		[ElementType("int8")]
		[Description("")]
		public byte[] Value { get; set; }

	    public string ValueString
	    {
	        get { return StringUtils.GetString(Value); }
	        set { Value = StringUtils.GetBytes(value, 61); }
	    }
    }
}
