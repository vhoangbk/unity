using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class game : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}

	int num = 500;
	int currentMin = 0;
	int currentMax = 1000;
	const int MAX = 1000;
	const int MIN = 0;

	public Text txtNum; 

	public void getBigger(){
		currentMin = num;
		nextNum ();
	}

	public void getLess(){
		currentMax = num;
		nextNum ();
	}

	public void nextNum(){
		num = (currentMax + currentMin) / 2;
		Debug.Log (num);
		txtNum.text = num.ToString();
	}
}
