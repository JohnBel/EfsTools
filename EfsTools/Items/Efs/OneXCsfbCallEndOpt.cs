using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/sd/1xcsfb_call_end_opt", true, 0xE1FF)]
    [Attributes(9)]
    public class OneXCsfbCallEndOpt
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}