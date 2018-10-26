using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/geran/grr/g2l_blind_redir_after_csfb_control", false, 0x81FF)]
	[Attributes(9)]
	public class G2lBlindRedirAfterCsfbControl
	{
		public G2lBlindRedirAfterCsfbControl()
		{
		}
		
	}
}
