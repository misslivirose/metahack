using UnityEngine;
using System.Collections;

public class KillGrid : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    Destroy(GameObject.Find("MetaGrid"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
