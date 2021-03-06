using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022014", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc10TxPdm1
    {
        [ElementsCount(64)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
