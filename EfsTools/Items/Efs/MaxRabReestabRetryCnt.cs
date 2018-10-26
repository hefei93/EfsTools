using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/data/3gpp/max_rab_reestab_retry_cnt", true, 0xE1FF)]
	[Attributes(9)]
	public class MaxRabReestabRetryCnt
	{
		public MaxRabReestabRetryCnt()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
