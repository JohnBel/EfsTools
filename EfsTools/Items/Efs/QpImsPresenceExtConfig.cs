using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_presence_ext_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsPresenceExtConfig
	{
		public QpImsPresenceExtConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field3 { get; set; }

		
		[ElementsCount(122)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Field4 { get; set; }

		
	}
}
