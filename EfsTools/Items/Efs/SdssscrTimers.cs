using System;
using System.ComponentModel;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/sd/sdssscr_timers", false, 0x81FF)]
    [Attributes(9)]
    public class SdssscrTimers
    {
        public SdssscrTimers()
        {
        }

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
        [ElementsCount(50)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] RawValue
        {
            get
            {
                return _value;
            }
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, 50);
                    Array.Copy(value, _value, len);
                }
            }
        }

        public uint[] Value
        {
            get
            {
                if (Count == 50)
                {
                    return _value;
                }
                var val = new uint[Count];
                var len = Math.Min((int)Count, 50);
                Array.Copy(_value, val, len);
                return val;
            }
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, 50);
                    Array.Copy(value, _value, len);
                    Count = (ushort)len;
                }
            }
        }

        private readonly uint[] _value = new uint[50];
    }
}