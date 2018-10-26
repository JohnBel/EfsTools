using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(6247)]
	[Attributes(9)]
	public class PppVsncpConfigData
    {
		public PppVsncpConfigData()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field4 { get; set; }

		
	}
}
