using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73527)]
    [EfsFile("/nv/item_files/ims/qp_ims_plani_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsPlaniConfig
    {
        public QpImsPlaniConfig()
        {
            SectorId = new byte[16];
            Mcc = new byte[6];
            Mnc = new byte[6];
            Reserved = new byte[65];
        }
        
        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint AccessType { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Lac { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Tac { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint CellIdentity { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Sid { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Nid { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Pzid { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort BaseId { get; set; }

        [JsonIgnore]
        [Optional]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] SectorId { get; set; }

        public string SectorIdString
        {
            get => StringUtils.GetString(SectorId);
            set => SectorId = StringUtils.GetBytes(value, 16);
        }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte SubnetLength { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeSeconds { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeMinutes { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeHours { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeDays { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeMonths { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeYears { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimeDayOfWeek { get; set; }

        [Optional]
        [JsonIgnore]
        [ElementsCount(6)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Mcc { get; set; }

        public string MccString
        {
            get => StringUtils.GetString(Mcc);
            set => Mcc = StringUtils.GetBytes(value, 48);
        }

        [Optional]
        [JsonIgnore]
        [ElementsCount(6)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Mnc { get; set; }

        public string MncString
        {
            get => StringUtils.GetString(Mnc);
            set => Mnc = StringUtils.GetBytes(value, 48);
        }

        [Optional]
        [ElementsCount(65)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}