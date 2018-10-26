using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/uim/gstk/proactive_feature_enable_cfg", true, 0xE1FF)]
	[Attributes(9)]
	public class ProactiveFeatureEnableCfg
	{
		public ProactiveFeatureEnableCfg()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
