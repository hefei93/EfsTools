using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2480)]
    [Attributes(9)]
    public class GsmVhThPrui13I
    {
        [ElementsCount(30)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}