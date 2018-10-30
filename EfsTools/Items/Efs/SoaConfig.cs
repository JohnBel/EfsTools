using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/mmode/cmph/soa_config", false, 0x81FF)]
    [Attributes(9)]
    public class SoaConfig
    {
    }
}