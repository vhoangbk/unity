using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		Debug.Log ("start");
	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log ("update");
	}

	public void loadLevel(string name){
		Debug.Log ("loadLevel() "+name);
		UnityEngine.SceneManagement.SceneManager.LoadScene (name);
		//Application.LoadLevel (name);
	}

	public void quitGame(){
		Application.Quit ();
	}
}
