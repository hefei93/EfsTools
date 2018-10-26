using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Serializable]
	[EfsFile("/ims/imshandoverconfig", false, 0x81FF)]
	[Attributes(9)]
	public class ImsHandoverConfig
    {
		public ImsHandoverConfig()
		{
		}

        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}
