using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/data/3gpp/lteps/profile_pdn_type_override", true, 0xE1FF)]
	[Attributes(9)]
	public class ProfilePdnTypeOverride
	{
		public ProfilePdnTypeOverride()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
