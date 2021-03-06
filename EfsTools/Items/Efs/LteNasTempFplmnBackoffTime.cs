using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/lte_nas_temp_fplmn_backoff_time", true, 0xE1FF)]
    [Attributes(9)]
    public class LteNasTempFplmnBackoffTime
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
    }
}