using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [NvItemId(71544)]
    [EfsFile("/nv/item_files/ims/qp_ims_cellid", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsCellid
    {
        public QpImsCellid()
        {
            CellId = new byte[192];
        }
        
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }
        
        [JsonIgnore]
        [ElementsCount(192)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] CellId { get; set; }

        public string CellIdString
        {
            get => StringUtils.GetString(CellId);
            set => CellId = StringUtils.GetBytes(value, 192);
        }
    }
}