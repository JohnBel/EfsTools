using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(6874)]
	[Attributes(25)]
	public class Asid1Data
	{
		public Asid1Data()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte Field2 { get; set; }

		
	}
}
