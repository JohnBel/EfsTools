using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/ds/atcop/atcop_cops_auto_mode.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class AtcopCopsAutoModeTxt
    {
    }
}