using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(7166)]
	[Attributes(9)]
	public class CdmaSo73Enabled
    {
		public CdmaSo73Enabled()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}