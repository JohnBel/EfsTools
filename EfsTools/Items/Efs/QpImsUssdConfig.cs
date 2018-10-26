using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_ussd_config", false, 0x81FF)]
	[Attributes(9)]
	public class QpImsUssdConfig
	{
		public QpImsUssdConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field2 { get; set; }

	    [Optional]
        [ElementsCount(509)]
	    [ElementType("uint8")]
	    [Description("")]
	    public byte[] Reserved { get; set; }
    }
}
