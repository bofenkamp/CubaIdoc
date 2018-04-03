using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

//	System.DateTime.Now

	public void LoadScene (string scene) {

		SceneManager.LoadScene (scene);

	}
}
