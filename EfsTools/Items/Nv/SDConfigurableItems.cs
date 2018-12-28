using System;
using System.ComponentModel;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3635)]
    [Attributes(9)]
    public class SdConfigurableItems
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Version { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Count { get; set; }

        [JsonIgnore]
        [ElementsCount(25)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] RawItems
        {
            get
            {
                return _items;
            }
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, _items.Length);
                    Array.Copy(value, _items, len);
                }
            }
        }


        public uint[] Items
        {
            get
            {
                if (Count >= 25)
                {
                    return _items;
                }
                var data = new uint[Count];
                Array.Copy(_items, data, Count);
                return data;
            }
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, _items.Length);
                    Array.Copy(value, _items, len);
                    Count = (ushort)len;
                }
            }
        }

        private readonly uint[] _items = new uint[25];
    }
}