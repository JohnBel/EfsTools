using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/Data_Profiles/Profile1", false, 0x81B6)]
	[Attributes(9)]
	public class Profile1
	{
		public Profile1()
		{
		}

	    [ElementsCount(0)]
	    [ElementType("uint8[]")]
	    [Description("")]
	    public byte[] Values { get; set; }
	}
}
