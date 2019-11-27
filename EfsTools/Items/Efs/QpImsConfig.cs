using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(69750)]
    [Subscription]
    [EfsFile("/nv/item_files/ims/qp_ims_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsConfig
    {
        public QpImsConfig()
        {
            Reserved = new byte[501];
        }

        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TipTirMode { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IrRestrictedType { get; set; }


        /*
         IMSOMADMServices
{
     0 = NONE
     1 = OMA_DM  -----------> RIL_IMS_NW_ENABLED_FLAG_PROVISION (Bit 0 - Enable(1)/Disable(0) OMA DM services)
     2 = VOICE  ------------> RIL_IMS_NW_ENABLED_FLAG_VOICE (Bit 1-  VoLTE enable(1)/disable(0) by OMA-DM)
     4 = VIDEO -------------> RIL_IMS_NW_ENABLED_FLAG_VIDEO (Bit 2 - VT enable(1)/disable(0) by OMA-DM)
     8 = EAB_PRESENCE ------> RIL_IMS_NW_ENABLED_FLAG_EAB (Bit 3 - Presence enable(1)/disable(0) by OMA-DM)
     15 = Enable all above services
}
         */
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint OmaDmServicesMask { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte WfcStatus { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CallModePreference { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ImsOperationSubmode { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IWfcRoaming { get; set; }

        [ElementsCount(501)]
        [ElementType("int8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}