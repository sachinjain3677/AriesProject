using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneManagement : MonoBehaviour {
	

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	public void LoadGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Main");
	}
	//public void LoadMenu()
	//{UnityEngine.SceneManagement.SceneManager.LoadScene ("MainMenu");
	//}
}
