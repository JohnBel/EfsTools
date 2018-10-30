using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/mpit_enabled", false, 0x81FF)]
    [Attributes(9)]
    public class MpitEnabled
    {
    }
}