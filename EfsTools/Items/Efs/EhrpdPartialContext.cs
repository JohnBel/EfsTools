using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/ehrpd_partial_context", false, 0x81FF)]
    [Attributes(9)]
    public class EhrpdPartialContext
    {
    }
}