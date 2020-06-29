using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025226", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19CaBcConfig : LteBandsConfigBase
    {
    }
}