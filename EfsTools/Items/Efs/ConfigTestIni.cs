using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/therm_monitor/config_test.ini", false, 0x81FF)]
	[Attributes(9)]
	public class ConfigTestIni
	{
		public ConfigTestIni()
		{
		}
	}
}
