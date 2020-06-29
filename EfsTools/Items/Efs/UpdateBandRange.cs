using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/ML1/update_band_range", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class UpdateBandRange
    {
        [JsonIgnore]
        [FieldCount(20)]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 20);
        }
    }
}