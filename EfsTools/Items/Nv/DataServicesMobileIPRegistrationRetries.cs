using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(460)]
    [Attributes(9)]
    public sealed class DataServicesMobileIpRegistrationRetries
    {
        public byte Value { get; set; }
    }
}