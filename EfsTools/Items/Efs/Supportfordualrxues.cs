using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/supportfordualrxues", true, 0xE1FF)]
	[Attributes(9)]
	public class Supportfordualrxues
	{
		public Supportfordualrxues()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
