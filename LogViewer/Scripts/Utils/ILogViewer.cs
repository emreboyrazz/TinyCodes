using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinyCodes.HELPERS.LogViewer{

	public interface ILogViewer {
		
		#region Private_Methods
		void StockLogMessagesAuto (string condition, string stackTrace, LogType type);
		void StockLogMessagesManuel (string log);
		#endregion


	}
}