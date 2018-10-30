using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/data/ds_eps_kamgr_pdn.txt", false, 0x8186)]
    [Attributes(9)]
    public class DsEpsKamgrPdnTxt
    {
    }
}