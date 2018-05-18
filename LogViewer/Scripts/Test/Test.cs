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
		for(int i=0;i<10;i++)
		{
			Debug.Log("Log one");
			Debug.Log("Log two");


		}

		Debug.LogError ("DEBUG ERROR");

		for(int i=0;i<11;i++)
		{
			Debug.Log("Log second");

		}
	}

}
