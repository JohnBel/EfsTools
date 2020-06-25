using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/data/pdn_policy_db.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class PdnPolicyDbTxt
    {
    }
}