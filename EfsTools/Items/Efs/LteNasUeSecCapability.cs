using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/lte_nas_ue_sec_capability", false, 0x81FF)]
    [Attributes(9)]
    public class LteNasUeSecCapability
    {
    }
}