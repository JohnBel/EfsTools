using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5737)]
    [Attributes(9)]
    public sealed class Bc15ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}