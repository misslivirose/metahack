using UnityEngine;
using System.Collections;
using Meta;
public class RotateWorldY : MonoBehaviour {
    public Transform spheringWheelTransform;
    public Transform spaceTransform;
	// Use this for initialization
	void Start () {
	
	}
	
    public void OnGrab()
    {
        //GetComponent<MetaBody>().hudLockRotation = true;
    }

    public void OnRelease()
    {
        //GetComponent<MetaBody>().hudLockRotation = false;
    }
	// Update is called once per frame
	void Update () {
        spaceTransform.rotation = spheringWheelTransform.rotation;
	}
}
