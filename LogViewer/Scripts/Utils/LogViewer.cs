using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TinyCodes.HELPERS.LogViewer{

	/// <summary>
	/// Attach to Main Controller (attached same GO with errorevents.cs)
	/// </summary>
	/// 

	public class LogViewer : AbstractLogViewer {

		#region Private_Fields
		#endregion

		#region Public_Fields
		public Text DebugText;


		#endregion

		void OnEnable(){
			Application.logMessageReceived+=StockLogMessagesAuto;
			GetComponent<LogViewerEvents> ().OnPrint += StockLogMessagesManuel;
		}
		void OnDisable(){
			Application.logMessageReceived -= StockLogMessagesAuto;
			GetComponent<LogViewerEvents> ().OnPrint -= StockLogMessagesManuel;
		}



		#region Public_Methods

		public void AutoPrintLogs(){
			PrintLogs(autoLogList);
		}
		public void ManuelPrintLogs(){
			PrintLogs(manuelLogList);
		}
		void PrintLogs(List<string> logList){
			DebugText.text = "";
			foreach (string logText in logList) {
				DebugText.text += logText;
			}
		}
		#endregion



	}
}