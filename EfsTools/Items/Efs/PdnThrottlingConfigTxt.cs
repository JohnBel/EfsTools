using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/epc/pdn_throttling_config.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class PdnThrottlingConfigTxt
    {
    }
}