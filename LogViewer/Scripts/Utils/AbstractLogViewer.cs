using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyCodes.HELPERS.LogViewer
{

	public abstract class AbstractLogViewer : MonoBehaviour,ILogViewer 
	{
		#region Protected_Fields

		protected List<string> autoLogList=new List<string>();
		protected List<string> manuelLogList=new List<string>();

		#endregion

		#region ILogViewer implementation

		public void StockLogMessagesAuto (string condition, string stackTrace, LogType type)
		{
			//Show Logs
			string newLog = "[" + type + "]:" + condition;

			//Show detailed error message
			if (type == LogType.Error)
			{
				newLog += "\n" + stackTrace;

			}
			autoLogList.Add (newLog);
		}

		public void StockLogMessagesManuel (string log)
		{
			string newManuelLog = "\n ManuelDebug : " + log;
			manuelLogList.Add (newManuelLog);
		}

		#endregion

	}
}
