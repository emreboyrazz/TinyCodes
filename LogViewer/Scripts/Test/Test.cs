using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyCodes.HELPERS.LogViewer;
public class Test : MonoBehaviour {
	 LogViewerEvents logViewerEvents;

	void Start () {
		logViewerEvents = FindObjectOfType<LogViewerEvents> ();
		// Print debug Manuel
		logViewerEvents.PrintLogsManuel ("DENEME1");
		logViewerEvents.PrintLogsManuel ("DENEME2");


		// Print debug Auto
		for(int i=0;i<1000;i++){
			Debug.Log("debug log");
		}


		Debug.LogError ("DEBUG ERROR");
	}

}
