using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_octet_aligned_mode_amr_nb", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallOctetAlignedModeAmrNb
	{
		public QipcallOctetAlignedModeAmrNb()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
