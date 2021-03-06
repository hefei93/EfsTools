using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/mac/hdr_dtx_cfg", true, 0xE1FF)]
    [Attributes(9)]
    public class HdrDtxCfg
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
    }
}