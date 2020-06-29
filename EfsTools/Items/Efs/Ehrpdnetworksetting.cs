using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/nv/item_files/modem/hdr/cp/scp/ehrpdnetworksetting", false, 0x81FF)]
    [Attributes(9)]
    public sealed class Ehrpdnetworksetting
    {
    }
}