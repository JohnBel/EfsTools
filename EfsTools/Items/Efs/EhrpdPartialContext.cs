using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/ehrpd_partial_context", false, 0x81FF)]
    [Attributes(9)]
    public sealed class EhrpdPartialContext
    {
    }
}