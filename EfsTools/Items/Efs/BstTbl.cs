using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/sd/bst_tbl", false, 0x81FF)]
    [Attributes(9)]
    public class BstTbl
    {
        /*[JsonIgnore]
        [ConvertEndian]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Length
        {
            get => _length;
            set
            {
                if (value > 40)
                {
                    _length = 40;
                }
                else
                {
                    _length = value;
                }
            }
        }

        private ushort _length;*/

        [ElementsCount(58)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}