using UnityEngine;
using System.Collections;

public class MyButton2 : MonoBehaviour {
  public void OnClick() {
    Debug.Log("Button2 click!");
    // ProfilePanelを非表示にする
    MyFPUI.SetActive("ProfilePanel", false);
  }
}
