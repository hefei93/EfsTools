using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025262", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB12C3RxGain
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
