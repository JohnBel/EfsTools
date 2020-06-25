using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Efs;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6828)]
    [Attributes(9)]
    public class LteBcConfig : LteBandsConfigBase
    {
    }
}