using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025205", true, 0xE1FF)]
    [Attributes(9)]
    public class Cdma1xBc15LteBc5DsiSarI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Cdma1xBc15LteBc5DsiSar { get; set; }
        
    }
}