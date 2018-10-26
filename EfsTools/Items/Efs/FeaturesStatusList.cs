using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/nv/item_files/modem/uim/mmgsdi/features_status_list", false, 0x81FF)]
	[Attributes(9)]
	public class FeaturesStatusList
	{
		public FeaturesStatusList()
		{
		}
		
	    [ElementsCount(64)]
	    [ElementType("uint8")]
	    [Description("")]
	    public byte[] Value { get; set; }
	}
}
