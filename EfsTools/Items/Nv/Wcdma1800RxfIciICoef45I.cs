using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6396)]
    [Attributes(9)]
    public class Wcdma1800RxfIciICoef45I
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
        
    }
}
