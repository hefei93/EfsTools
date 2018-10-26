using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/ims/qipcall_dan_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class QipcallDanEnable
	{
		public QipcallDanEnable()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
