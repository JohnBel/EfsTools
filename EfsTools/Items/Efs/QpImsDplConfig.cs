using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qp_ims_dpl_config", true, 0xE1FF)]
	[Attributes(9)]
	public class QpImsDplConfig
	{
		public QpImsDplConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort PtimeValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort InitialBufferTimeValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte AmrMode { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Ipv6Enabled { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort MsRpPktSz { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte DscpValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint RuimImsiValue { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte ImsParamSrc { get; set; }
	}
}
