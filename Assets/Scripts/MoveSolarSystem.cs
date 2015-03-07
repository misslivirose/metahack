using UnityEngine;
using System.Collections;

public class MoveSolarSystem : MonoBehaviour {

    public Transform spheringWheelTransform;
    public Transform spaceTransform;
	public float speed = .1f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnHold()
    {
        //GetComponent<MetaBody>().hudLockRotation = true;
		spaceTransform.Translate (Vector3.forward * Time.deltaTime * speed); 
        

    }


//    public void OnTouchDwell()
//    {
//        spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
//    }

}
