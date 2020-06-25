using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3635)]
    [Attributes(9)]
    public sealed class SdConfigurableItems
    {
        [Required]
        public ushort Version { get; set; }

        [JsonIgnore]
        public ushort Count { get; set; }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
        private readonly uint[] _items = new uint[25];

        [JsonIgnore]
        public uint[] RawItems
        {
            get => _items;
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
                    Count = (ushort) len;
                }
            }
        }
    }
}