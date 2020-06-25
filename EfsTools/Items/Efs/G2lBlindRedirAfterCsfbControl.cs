using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/geran/grr/g2l_blind_redir_after_csfb_control", false, 0x81FF)]
    [Attributes(9)]
    public sealed class G2lBlindRedirAfterCsfbControl
    {
    }
}