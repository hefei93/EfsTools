using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023760", true, 0xE1FF)]
    [Attributes(9)]
    public class LteC1SpursTable
    {
        [ElementsCount(30)]
        [ElementType("QMSL_Rx_SPUR_Table_NV_Type")]
        [Description("")]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
        
    }
}
