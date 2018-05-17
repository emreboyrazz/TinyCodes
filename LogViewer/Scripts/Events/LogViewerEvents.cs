using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attach to Main Controller (attached same GO with LogViewer.cs) 
/// </summary>
/// 
using System;


namespace TinyCodes.HELPERS.LogViewer
{
	
	public class LogViewerEvents : MonoBehaviour 
	{
		#region Events

		public event Action<String> OnPrint;

		#endregion

		#region Public_Methods

		public void PrintLogsManuel(string text)
		{
			if (OnPrint != null)
				OnPrint (text);
		}

		#endregion
	}
}