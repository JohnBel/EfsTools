using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/modem/mmode/ue_usage_setting", true, 0xE1FF)]
	[Attributes(9)]
	public class UeUsageSetting
	{
		public UeUsageSetting()
		{
		}

	    [ElementsCount(1)]
	    [ElementType("uint8")]
	    [Description("")]
	    public byte Value { get; set; }
    }
}
