using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6555)]
    [Attributes(9)]
    public class LteB7AgcTxOnRiseFallDelay
    {
        [ElementsCount(2)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}
