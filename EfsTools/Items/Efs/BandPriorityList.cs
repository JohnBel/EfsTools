using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte/rrc/csp/band_priority_list", false, 0x81FF)]
    [Attributes(9)]
    public sealed class BandPriorityList
    {
    }
}