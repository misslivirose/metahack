using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {
	public Transform target;
	public float pDistance =1f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relativePos = (target.position + new Vector3(0	, 0, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		
		Quaternion current = transform.localRotation;
		
		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
		float x = Random.Range(1.0F, 2.0F);
		transform.Translate(0, 0, x * Time.deltaTime);
	}
}
