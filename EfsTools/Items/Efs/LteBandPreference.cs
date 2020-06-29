using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/lte_bandpref", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteBandPreference : LteBandsConfigBase
    {
    }
}