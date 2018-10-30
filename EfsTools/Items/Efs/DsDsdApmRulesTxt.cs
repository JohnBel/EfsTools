using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/data/ds_dsd_apm_rules.txt", false, 0x81B6)]
    [Attributes(9)]
    public class DsDsdApmRulesTxt
    {
    }
}