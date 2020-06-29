using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(461)]
    [Attributes(9)]
    public sealed class DataServicesMobileIpRegistrationRetriesInitialInterval
    {
        public byte Value { get; set; }
    }
}