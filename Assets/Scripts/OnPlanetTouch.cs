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

	//public void OnGazeHold(){
	//	Debug.Log ("Gazing");
	//}


//    public void OnHold()
//    {
//        //GetComponent<MetaBody>().hudLockRotation = true;
//        Debug.Log("Was Dwelled");
//
//    }
}
