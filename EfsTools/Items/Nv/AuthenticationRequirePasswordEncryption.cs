using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1907)]
	[Attributes(9)]
	public class AuthenticationRequirePasswordEncryption
    {
		public AuthenticationRequirePasswordEncryption()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
