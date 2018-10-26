using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/lte/rrc/cep/conn_control_barring_optmz_enable", false, 0x81FF)]
	[Attributes(9)]
	public class ConnControlBarringOptmzEnable
	{
		public ConnControlBarringOptmzEnable()
		{
		}
		
	}
}
