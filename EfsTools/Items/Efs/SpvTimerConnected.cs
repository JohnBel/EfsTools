using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/ML1/spv_timer_connected", false, 0x81FF)]
    [Attributes(9)]
    public sealed class SpvTimerConnected
    {
    }
}