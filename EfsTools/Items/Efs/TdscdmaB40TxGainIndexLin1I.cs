using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022721", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB40TxGainIndexLin1I
    {
        [ElementsCount(64)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}