using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4396)]
    [Attributes(9)]
    public sealed class DsMobileIpDeregistrationRetries
    {
        public byte Value { get; set; }
    }
}