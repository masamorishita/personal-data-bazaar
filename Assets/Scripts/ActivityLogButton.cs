using UnityEngine;
using System.Collections;

public class ActivityLogButton : MonoBehaviour {
  public void OnClick() {
    Debug.Log("Button click!");
    MySPUI.SetActive("ActivityLog", true);
    MySPUI.SetActive("ARUI1", false);
  }
}