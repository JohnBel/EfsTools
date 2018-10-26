using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1895)]
	[Attributes(9)]
	public class DiagDebugDetail
    {
		public DiagDebugDetail()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte Value { get; set; }

		
	}
}
