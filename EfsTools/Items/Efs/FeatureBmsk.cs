using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/modem/uim/gstk/feature_bmsk", false, 0x81FF)]
	[Attributes(9)]
	public class FeatureBmsk
	{
		public FeatureBmsk()
		{
		}
		
	}
}
