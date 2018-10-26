using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(3630)]
	[Attributes(9)]
	public class EdaFeatureSupport
    {
		public EdaFeatureSupport()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
