using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(4231)]
	[Attributes(9)]
	public class HdrL1DebugMask
    {
		public HdrL1DebugMask()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint64")]
		[Description("")]
		public ulong Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint64")]
		[Description("")]
		public ulong Field2 { get; set; }

		
	}
}
