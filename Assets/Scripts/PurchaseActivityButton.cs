using UnityEngine;
using System.Collections;

public class PurchaseActivityButton : MonoBehaviour {
  public void OnClick() {
    Debug.Log("Button click!");
    MySPUI.SetActive("PurchaseOrder", true);
    MySPUI.SetActive("ActivityLog", false);
  }
}
