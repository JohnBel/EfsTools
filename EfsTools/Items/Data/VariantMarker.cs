using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class VariantMarker
    {
        public ushort Version { get; set; }


        public ushort NumOfElement { get; set; }
    }
}