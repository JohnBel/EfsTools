using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qipcall_is_conference_aware", true, 0xE1FF)]
    [Attributes(9)]
    public class QipcallIsConferenceAware
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        /*
         Set to 1 - ALL 
         Set to 2 - ORIGINATOR_ONLY 
         Set to 3 - ORIGINATOR_ONLY_NO_JOIN_IND 
         */
    }
}