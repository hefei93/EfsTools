using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/lte_bandpref", true, 0xE1FF)]
    [Attributes(9)]
    public class LteBandPref : LteBandsConfigBase
    {
    }
}