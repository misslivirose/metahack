using UnityEngine;
using System.Collections;

public class MoveSolarSystem : MonoBehaviour {

    public Transform spaceTransform;
	public Transform origin; 
	public float speed = .1f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (WorldController.gazing) {
			//if not .4 away; Vector between curpos and origin< .4 
			if(Vector3.Distance(origin.position, spaceTransform.position) < .4f){
				spaceTransform.LookAt(WorldController.Target.transform); 
				spaceTransform.Translate (Vector3.forward * Time.deltaTime * speed); 

			}
		} else {
			//Move Home
		}
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
