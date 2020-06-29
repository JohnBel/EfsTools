using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/data/pdn_policy_db.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class PdnPolicyDbTxt
    {
    }
}