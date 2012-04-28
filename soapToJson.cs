using System;
using System.Collections.Generic;

namespace Application
{
	public class soapToJson
	{
		private string p_urlSOAP;
		
		public string urlSOAP{
			get{
					return p_urlSOAP;		
			}
			set
			{
					p_urlSOAP=value;	
			}			
		}

		
		private List<string> p_methodsToConvert;		
		public List<string> methodsToConvert{
			get{
					return p_methodsToConvert;		
			}
			set
			{
					p_methodsToConvert=value;	
			}			
		}
		
		
		public soapToJson ()
		{
		}
		
		
	}
}

