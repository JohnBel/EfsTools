using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(6850)]
	[Attributes(9)]
	public class UmtsAmrCodecPreferenceConfig
    {
		public UmtsAmrCodecPreferenceConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
