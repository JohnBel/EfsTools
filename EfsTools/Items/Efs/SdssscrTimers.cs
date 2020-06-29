using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/sd/sdssscr_timers", false, 0x81FF)]
    [Attributes(9)]
    public sealed class SdssscrTimers
    {
        

        [Required]
        public ushort Version { get; set; }

        [JsonIgnore]
        public ushort Count { get; set; }


        [FieldCount(50)]
        private readonly uint[] _value = new uint[50];
        
        [JsonIgnore]
        public uint[] RawValue
        {
            get => _value;
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
                var len = Math.Min((int) Count, 50);
                Array.Copy(_value, val, len);
                return val;
            }
            set
            {
                if (value != null)
                {
                    var len = Math.Min(value.Length, 50);
                    Array.Copy(value, _value, len);
                    Count = (ushort) len;
                }
            }
        }
    }
}