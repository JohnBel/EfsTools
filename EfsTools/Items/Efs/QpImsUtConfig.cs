using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_ut_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsUtConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }

        [JsonIgnore]
        [ElementsCount(64)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field2 { get; set; }

        public string Field2String
        {
            get => StringUtils.GetString(Field2);
            set => Field2 = StringUtils.GetBytes(value, 64);
        }

        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field3 { get; set; }

        public string Field3String
        {
            get => StringUtils.GetString(Field3);
            set => Field3 = StringUtils.GetBytes(value, 256);
        }


        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field4 { get; set; }

        public string Field4String
        {
            get => StringUtils.GetString(Field4);
            set => Field4 = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field5 { get; set; }

        public string Field5String
        {
            get => StringUtils.GetString(Field5);
            set => Field5 = StringUtils.GetBytes(value, 128);
        }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field11 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field12 { get; set; }

        [JsonIgnore]
        [ElementsCount(64)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field13 { get; set; }

        public string Field13String
        {
            get => StringUtils.GetString(Field13);
            set => Field13 = StringUtils.GetBytes(value, 64);
        }

        [JsonIgnore]
        [ElementsCount(217)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field14 { get; set; }

        public string Field14String
        {
            get => StringUtils.GetString(Field14);
            set => Field14 = StringUtils.GetBytes(value, 217);
        }
    }
}