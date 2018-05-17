using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour 
{
	#region Public_Fields

	public Transform LogTextContainer;
	public GameObject LogViewerPanel;
	public Sprite ClosedSprite;
	public Sprite OpenedSprite;

	#endregion

	#region Private_Fields

	private bool isPanelVisible = true;

	#endregion

	public void PanelVisibility()
	{
		if (isPanelVisible) 
		{
			ClosePanel ();
		} 
		else 
		{
			OpenPanel ();
		}
		isPanelVisible = !isPanelVisible;
		LogViewerPanel.SetActive (isPanelVisible);
	}

	public void ClosePanel()
	{
		DestroyLog ();
		EventSystem.current.currentSelectedGameObject.transform.GetChild (0).GetChild (0).GetComponent<Image> ().sprite = ClosedSprite;
	}

	public void OpenPanel()
	{
		EventSystem.current.currentSelectedGameObject.transform.GetChild (0).GetChild (0).GetComponent<Image> ().sprite = OpenedSprite;
	}

	// No need this method -Also used same method in LogViewer.cs-
	private void DestroyLog()
	{
		foreach (Transform child in LogTextContainer) 
		{
			GameObject.Destroy(child.gameObject);
		}
	}
}
