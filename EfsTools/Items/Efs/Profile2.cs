using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/Data_Profiles/Profile2", false, 0x81B6)]
	[Attributes(9)]
	public class Profile2
	{
		public Profile2()
		{
		}

	    [ElementsCount(0)]
	    [ElementType("uint8[]")]
	    [Description("")]
	    public byte[] Values { get; set; }
    }
}
