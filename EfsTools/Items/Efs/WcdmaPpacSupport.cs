using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/wcdma/rrc/wcdma_ppac_support", true, 0xE1FF)]
    [Attributes(9)]
    public class WcdmaPpacSupport
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}