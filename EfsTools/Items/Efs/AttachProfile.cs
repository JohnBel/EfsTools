using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/data/3gpp/lteps/attach_profile", true, 0xE1FF)]
	[Attributes(9)]
	public class AttachProfile
	{
		public AttachProfile()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }
	}
}
