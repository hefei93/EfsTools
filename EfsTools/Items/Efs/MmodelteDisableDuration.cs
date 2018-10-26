using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmodelte_disable_duration", true, 0xE1FF)]
	[Attributes(9)]
	public class MmodelteDisableDuration
	{
		public MmodelteDisableDuration()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
