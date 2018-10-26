using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/lte_bandpref", true, 0xE1FF)]
	[Attributes(9)]
	public class LteBandpref
	{
		public LteBandpref()
		{
		}
		
		[ElementsCount(8)]
		[ElementType("int8")]
		[Description("")]
        public sbyte Value { get; set; }
    }
}
