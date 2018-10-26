using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/ims_hybrid_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class ImsHybridEnable
	{
		public ImsHybridEnable()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}