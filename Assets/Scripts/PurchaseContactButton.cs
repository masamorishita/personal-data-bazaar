using UnityEngine;
using System.Collections;

public class PurchaseContactButton : MonoBehaviour {
  public void OnClick() {
    Debug.Log("Button click!");
    MySPUI.SetActive("ARUI1", true);
    MySPUI.SetActive("ContactInfo", false);
  }
}
