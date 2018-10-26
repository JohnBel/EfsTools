using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/pdp_profiles/tethered_call_prof_num", false, 0x81FF)]
	[Attributes(9)]
	public class TetheredCallProfNum
	{
		public TetheredCallProfNum()
		{
		}
		
	}
}
