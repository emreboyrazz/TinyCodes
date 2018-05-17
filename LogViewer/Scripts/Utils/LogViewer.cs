using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TinyCodes.HELPERS.LogViewer
{

	/// <summary>
	/// Attach to Main Controller (attached same gameobject with LogViewerEvents.cs)
	/// </summary>
	/// 
	[RequireComponent(typeof(LogViewerEvents))]
	public class LogViewer : AbstractLogViewer 
	{
		#region Public_Fields

		public GameObject LogTextFieldPrefab;
		public Transform LogTextContainer;

		#endregion


		void OnEnable()
		{
			Application.logMessageReceived+=StockLogMessagesAuto;
			GetComponent<LogViewerEvents> ().OnPrint += StockLogMessagesManuel;
		}
		void OnDisable()
		{
			Application.logMessageReceived -= StockLogMessagesAuto;
			GetComponent<LogViewerEvents> ().OnPrint -= StockLogMessagesManuel;
		}



		#region Public_Methods

		public void AutoPrintLogs()
		{
			PrintLogs(autoLogList);
		}
		public void ManuelPrintLogs()
		{
			PrintLogs(manuelLogList);
		}

		#endregion

		#region Prıvate_Methods

		/*
			- Controll If there is unCatched errors in update 
			- Limit instantiated objects
		*/
		void PrintLogs(List<string> logList)
		{
			DestroyInstantiatedObbjects ();
			for (int i=0;i<logList.Count;i++) 
			{
				//Collapse
				if (i > 0 && logList [i].Equals(logList [i - 1])) {
					continue;
				}
				GameObject instantiated = Instantiate (LogTextFieldPrefab, LogTextContainer);
				instantiated.GetComponent<LogStruct> ().LogText.text = logList[i];

			}
		}
		void DestroyInstantiatedObbjects()
		{
			foreach (Transform child in LogTextContainer) 
			{
				GameObject.Destroy(child.gameObject);
			}
		}

		#endregion

	}
}