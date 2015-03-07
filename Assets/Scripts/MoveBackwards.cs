using UnityEngine;
using System.Collections;
using Meta;

public class MoveBackwards : MonoBehaviour {
	public Transform spaceTransform;
	public float speed = .1f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnHold(){
		spaceTransform.Translate (Vector3.back * Time.deltaTime * speed); 
	}
//
//    public void OnTouchDwell()
//    {
//        spaceTransform.Translate(Vector3.back * Time.deltaTime * speed);
//    }
}
