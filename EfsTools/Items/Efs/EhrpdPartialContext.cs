using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/data/3gpp2/ehrpd_partial_context", false, 0x81FF)]
	[Attributes(9)]
	public class EhrpdPartialContext
	{
		public EhrpdPartialContext()
		{
		}
		
	}
}
