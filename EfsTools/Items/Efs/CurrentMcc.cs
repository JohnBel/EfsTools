using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/policyman/current_mcc", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CurrentMcc

    {
        public uint Value { get; set; }
    }
}