using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/tdscdma/rrc/fake_sec_enabled", true, 0xE1FF)]
	[Attributes(9)]
	public class FakeSecEnabled
	{
		public FakeSecEnabled()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
