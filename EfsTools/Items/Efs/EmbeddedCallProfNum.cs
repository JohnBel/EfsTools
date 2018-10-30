using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/pdp_profiles/embedded_call_prof_num", false, 0x81FF)]
    [Attributes(9)]
    public class EmbeddedCallProfNum
    {
    }
}