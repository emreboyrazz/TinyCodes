using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyCodes.HELPERS.LogViewer
{

	public abstract class AbstractLogViewer : MonoBehaviour,ILogViewer 
	{
		public struct Logs{
			public string value;
			public int counter;
		}
		#region Protected_Fields

		//protected List<string> autoLogList=new List<string>();
		protected List<Logs> manuelLogList=new List<Logs>();

		protected List<Logs> autoLogList = new List<Logs>();


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
			Collapse (newLog,autoLogList);
		}

		public void StockLogMessagesManuel (string log)
		{
			string newManuelLog = "\n ManuelDebug : " + log;
			Collapse (newManuelLog,manuelLogList);
		}

		#endregion

		private void Collapse(string logMessage,List<Logs> logList)
		{
			Logs logs = new Logs ();
			logs.value = logMessage;
			logs.counter = 1;

			if (!logList.Exists(x => x.value == logMessage))
			{
				logList.Add (logs);
			}
			else 
			{
				int index = logList.FindIndex(item => item.value == logMessage);
				logs.value = logMessage;
				logs.counter = logList [index].counter+1;

				logList [index] = logs;

			}
		}

	}
}
