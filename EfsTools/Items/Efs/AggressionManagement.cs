using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/aggression_management", true, 0xE1FF)]
    [Attributes(9)]
    public class AggressionManagement
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}