using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/pdp_profiles/tethered_call_prof_nums", false, 0x81FF)]
    [Attributes(9)]
    public sealed class TetheredCallProfNums
    {
    }
}