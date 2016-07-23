using UnityEngine;
using System.Collections;

public class OkButton : MonoBehaviour {
  public void OnClick() {
    Debug.Log("Button click!");
    MySPUI.SetActive("ARUI1", true);
    MySPUI.SetActive("PurchaseOrder", false);
  }
}