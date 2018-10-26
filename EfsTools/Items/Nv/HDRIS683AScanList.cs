using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(6429)]
	[Attributes(41)]
	public class HdrIs683AScanList
    {
		public HdrIs683AScanList()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field3 { get; set; }

		
	}
}
