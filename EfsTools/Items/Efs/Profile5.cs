using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/Data_Profiles/Profile5", false, 0x81B6)]
    [Attributes(9)]
    public sealed class Profile5 : ProfileBase
    {
    }
}