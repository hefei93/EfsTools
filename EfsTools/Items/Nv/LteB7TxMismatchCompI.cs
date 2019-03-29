using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6819)]
    [Attributes(9)]
    public class LteB7TxMismatchComp
    {
        [ElementsCount(2)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
