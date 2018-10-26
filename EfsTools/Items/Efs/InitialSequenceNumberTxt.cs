using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/eHRPD/initial_sequence_number.txt", false, 0x81FF)]
	[Attributes(9)]
	public class InitialSequenceNumberTxt
	{
		public InitialSequenceNumberTxt()
		{
		}
		
	}
}
