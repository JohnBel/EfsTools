using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73527)]
    [Subscription]
    [EfsFile("/nv/item_files/ims/qp_ims_plani_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsPlaniConfig
    {
        public QpImsPlaniConfig()
        {
            SectorId = new byte[16];
            Mcc = new byte[6];
            Mnc = new byte[6];
            Reserved = new byte[65];
        }

        [Required]
        public byte Version { get; set; }


        public uint AccessType { get; set; }


        public ushort Lac { get; set; }


        public ushort Tac { get; set; }


        public uint CellIdentity { get; set; }


        public ushort Sid { get; set; }


        public ushort Nid { get; set; }


        public ushort Pzid { get; set; }


        public ushort BaseId { get; set; }

        [JsonIgnore]
        [FieldCount(16)]
        public byte[] SectorId { get; set; }

        public string SectorIdString
        {
            get => StringUtils.GetString(SectorId);
            set => SectorId = StringUtils.GetBytes(value, 16);
        }


        public byte SubnetLength { get; set; }


        public ushort TimeSeconds { get; set; }


        public ushort TimeMinutes { get; set; }


        public ushort TimeHours { get; set; }


        public ushort TimeDays { get; set; }


        public ushort TimeMonths { get; set; }


        public ushort TimeYears { get; set; }


        public ushort TimeDayOfWeek { get; set; }

        [JsonIgnore]
        [FieldCount(6)]
        public byte[] Mcc { get; set; }

        public string MccString
        {
            get => StringUtils.GetString(Mcc);
            set => Mcc = StringUtils.GetBytes(value, 48);
        }

        [JsonIgnore]
        [FieldCount(6)]
        public byte[] Mnc { get; set; }

        public string MncString
        {
            get => StringUtils.GetString(Mnc);
            set => Mnc = StringUtils.GetBytes(value, 48);
        }

        [FieldCount(65)]
        public byte[] Reserved { get; set; }
    }
}