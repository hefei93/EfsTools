using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/tds_bandpref", true, 0xE1FF)]
	[Attributes(9)]
	public class TdsBandPref
	{
		public TdsBandPref()
		{
		}
		
		[ElementsCount(8)]
		[ElementType("uint8")]
		[Description("")]
        public byte[] Value { get; set; }
    }
}
