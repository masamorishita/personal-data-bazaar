using UnityEngine;
using System.Collections;

public class ContactInfoButton : MonoBehaviour {
  public void OnClick() {
    Debug.Log("Button click!");
    MySPUI.SetActive("ContactInfo", true);
    MySPUI.SetActive("ARUI1", false);
  }
}
