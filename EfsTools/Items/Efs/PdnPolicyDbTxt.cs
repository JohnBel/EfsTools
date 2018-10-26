using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/data/pdn_policy_db.txt", false, 0x81B6)]
	[Attributes(9)]
	public class PdnPolicyDbTxt
	{
		public PdnPolicyDbTxt()
		{
		}
		
	}
}
