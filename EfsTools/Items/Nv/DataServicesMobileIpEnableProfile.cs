using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(714)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpEnableProfile
    {
        public DataServicesMobileIpEnableProfile()
        {
            EnableProfs = new byte[6];
        }

        [FieldCount(6)]
        public byte[] EnableProfs { get; set; }
    }
}