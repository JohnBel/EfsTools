using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/policyman/segment_loading.xml", false, 0x81FF)]
    [Attributes(9)]
    public class SegmentLoadingXml
    {
    }
}