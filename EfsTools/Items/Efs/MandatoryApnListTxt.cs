using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/eHRPD/mandatory_apn_list.txt", false, 0x81FF)]
	[Attributes(9)]
	public class MandatoryApnListTxt
	{
		public MandatoryApnListTxt()
		{
		}
		
	}
}
