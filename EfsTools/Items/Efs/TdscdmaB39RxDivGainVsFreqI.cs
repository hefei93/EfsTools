using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024205", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB39RxDivGainVsFreqI
    {
        [ElementsCount(64)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}