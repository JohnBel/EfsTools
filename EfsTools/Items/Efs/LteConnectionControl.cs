using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte_connection_control", false, 0x81FF)]
    [Attributes(9)]
    public sealed class LteConnectionControl
    {
    }
}