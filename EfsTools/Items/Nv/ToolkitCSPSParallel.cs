using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5770)]
    [Attributes(9)]
    public sealed class ToolkitCsPsParallel
    {
        public byte Value { get; set; }
    }
}