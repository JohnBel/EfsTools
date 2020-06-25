using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/pdp_profiles/consl_profiles/socks_call_prof_num", false, 0x81FF)]
    [Attributes(9)]
    public sealed class SocksCallProfNum
    {
    }
}