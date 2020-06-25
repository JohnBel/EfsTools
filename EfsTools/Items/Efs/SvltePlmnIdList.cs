using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/mmode/cmph/svlte_plmn_id_list", false, 0x81FF)]
    [Attributes(9)]
    public sealed class SvltePlmnIdList
    {
    }
}