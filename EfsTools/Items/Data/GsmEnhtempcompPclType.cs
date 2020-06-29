using System;
using BinarySerialization;

namespace EfsTools.Items.Data
{
    [Serializable]
    
    public sealed class GsmEnhtempcompPclType
    {
        [FieldCount(16)]
        public short[] PwrIndex
        {
            get;
        }
    }
}