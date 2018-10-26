using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/voip_prfrd_codec", true, 0xE1FF)]
	[Attributes(9)]
	public class VoipPrfrdCodec
	{
		public VoipPrfrdCodec()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }
    }
}
