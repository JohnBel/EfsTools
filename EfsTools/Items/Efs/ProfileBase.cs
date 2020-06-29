using System;

namespace EfsTools.Items.Efs
{
    [Serializable]
        public class ProfileBase
    {
        [FieldCount(0)]
        public byte[] Values
        {
            get;
        }
    }
}