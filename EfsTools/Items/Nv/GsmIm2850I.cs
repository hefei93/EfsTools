using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4174)]
    [Attributes(9)]
    public class GsmIm2850
    {
        [ElementsCount(3)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value1 { get; set; }
        
        [ElementsCount(7)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value2 { get; set; }
        
    }
}
