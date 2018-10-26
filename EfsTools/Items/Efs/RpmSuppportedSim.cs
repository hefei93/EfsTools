using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/data/3gpp/rpm_suppported_sim", true, 0xE1FF)]
	[Attributes(9)]
	public class RpmSuppportedSim
	{
		public RpmSuppportedSim()
		{
		}
		
		[ElementsCount(60)]
		[ElementType("uint8")]
		[Description("")]
		public byte[] Value { get; set; }

	    public string ValueString
        {
	        get { return StringUtils.GetString(Value); }
	        set { Value = StringUtils.GetBytes(value, 60); }
	    }
    }
}
