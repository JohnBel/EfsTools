using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(260)]
    [Attributes(41)]
    public sealed class OtaPaEnabled
    {
        public byte Nam { get; set; }


        public byte Enabled { get; set; }
    }
}