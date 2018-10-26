using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1962)]
	[Attributes(9)]
	public class TraceFilesSavedEFS
    {
		public TraceFilesSavedEFS()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte Value { get; set; }

		
	}
}
