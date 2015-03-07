using UnityEngine;
using System.Collections;
using Meta;

public class OnPlanetTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTouchDwell()
	{
		//renderer.material.color = Color.cyan;
		Debug.Log ("Was Dwelled");
	}

	public void OnGazeDwell(){
		Debug.Log ("Gazing");
		WorldController.gazing = true; 
	}

	public void OnGazeDwellExit(){
		Debug.Log ("Stopped Gazing");
	}

//	public void OnGazeExit(){
//	
//		Debug.Log ("Stopped Gazing");
//	}

//    public void OnHold()
//    {
//        //GetComponent<MetaBody>().hudLockRotation = true;
//        Debug.Log("Was Dwelled");
//
//    }
}
