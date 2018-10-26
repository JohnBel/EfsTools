using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/nas/ehplmn", true, 0xE1FF)]
	[Attributes(9)]
	public class Ehplmn
	{
		public Ehplmn()
		{
		}
		
		[ElementsCount(61)]
		[ElementType("int8")]
		[Description("")]
        public byte[] Value { get; set; }

		
	}
}
