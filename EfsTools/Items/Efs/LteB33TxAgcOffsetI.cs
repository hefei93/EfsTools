using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024871", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxAgcOffsetI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] LteTxAgcOffset { get; set; }
        
    }
}