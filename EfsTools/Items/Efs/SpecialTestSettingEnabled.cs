using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/tdscdma/rrc/special_test_setting_enabled", true, 0xE1FF)]
	[Attributes(9)]
	public class SpecialTestSettingEnabled
	{
		public SpecialTestSettingEnabled()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
