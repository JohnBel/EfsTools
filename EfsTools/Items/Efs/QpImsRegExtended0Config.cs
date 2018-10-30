using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_reg_extended_0_config", false, 0x81B6)]
    [Attributes(9)]
    public class QpImsRegExtended0Config
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field2 { get; set; }

        [ElementsCount(1019)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field3 { get; set; }

        /*public string Field3String
        {
            get { return StringUtils.GetString(Field3); }
            set { Field3 = StringUtils.GetBytes(value, 1019); }
        }*/

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field4 { get; set; }
    }
}