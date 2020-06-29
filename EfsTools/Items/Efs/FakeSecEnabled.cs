using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/tdscdma/rrc/fake_sec_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FakeSecEnabled
    {
        public byte Value { get; set; }
    }
}