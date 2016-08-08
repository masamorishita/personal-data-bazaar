using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Launch : MonoBehaviour {
	void Start()
	{
		Invoke("Call",5);
	}
	void Call()
	{
		SceneManager.LoadScene("Login");
	}
}