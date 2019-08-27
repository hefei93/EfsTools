using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/Data_Profiles/Profile4", false, 0x81B6)]
    [Attributes(9)]
    public class Profile4
    {
        [ElementsCount(0)]
        [ElementType("uint8[]")]
        [Description("")]
        public byte[] Values { get; set; }
    }
}