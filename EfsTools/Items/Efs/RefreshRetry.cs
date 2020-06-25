using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/refresh_retry", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RefreshRetry
    {
        public uint Field1 { get; set; }


        public uint Field2 { get; set; }


        public uint Field3 { get; set; }


        public uint Field4 { get; set; }
    }
}