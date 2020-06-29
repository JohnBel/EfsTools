using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7226)]
    [Attributes(9)]
    public sealed class LteB13ExpLpmHdetVsAgc
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}