using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/Data_Profiles/Profile1", false, 0x81B6)]
    [Attributes(9)]
    public sealed class Profile1 : ProfileBase
    {
    }
}