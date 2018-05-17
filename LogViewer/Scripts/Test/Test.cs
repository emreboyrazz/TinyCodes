using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyCodes.HELPERS.LogViewer;
public class Test : MonoBehaviour 
{
	 LogViewerEvents logViewerEvents;

	void Start () 
	{
		logViewerEvents = FindObjectOfType<LogViewerEvents> ();

		// Print Log Manuel
		logViewerEvents.PrintLogsManuel ("TEST1");
		logViewerEvents.PrintLogsManuel ("TEST2");
		logViewerEvents.PrintLogsManuel ("TEST3");

		// Print Log Auto
		for(int i=0;i<1000;i++)
		{
			Debug.Log("debug log");
		}

		Debug.LogError ("DEBUG ERROR");
	}

}
