using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/ehrpd_to_hrpd_fallback", false, 0x81FF)]
    [Attributes(9)]
    public sealed class EhrpdToHrpdFallback
    {
    }
}