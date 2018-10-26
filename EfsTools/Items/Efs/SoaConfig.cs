using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/mmode/cmph/soa_config", false, 0x81FF)]
	[Attributes(9)]
	public class SoaConfig
	{
		public SoaConfig()
		{
		}
		
	}
}
