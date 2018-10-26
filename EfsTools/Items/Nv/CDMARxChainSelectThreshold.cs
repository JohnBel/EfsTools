using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(3515)]
	[Attributes(9)]
	public class CdmaRxChainSelectThreshold
    {
		public CdmaRxChainSelectThreshold()
		{
		}
		
		[ElementsCount(2)]
		[ElementType("int16")]
		[Description("")]
		public short[] Value { get; set; }
    }
}
