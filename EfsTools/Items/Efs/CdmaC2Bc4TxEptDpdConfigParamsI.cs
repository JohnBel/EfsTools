using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024152", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc4TxEptDpdConfigParams
    {
        private TxXptDpdConfigParamsDataType _xptCfgParams = new TxXptDpdConfigParamsDataType();
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }
}