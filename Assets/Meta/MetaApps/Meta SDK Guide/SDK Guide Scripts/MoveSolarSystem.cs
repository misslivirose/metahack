using UnityEngine;
using System.Collections;
public class MoveSolarSystem : MonoBehaviour
{
	public Transform spaceTransform;
	public Transform origin;
	public float speed = .3f;
	public float distance = .45f; 
	public static AudioClip SaberOn; 
	AudioSource playerSound; 
	// Use this for initialization
	void Start()
	{
		playerSound = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (WorldController.gazing)
		{
			//if not .4 away; Vector between curpos and origin< .4 
			//Debug.Log("Target: " + WorldController.Target.tag); 
			float x;
			if (WorldController.Target != null && (x = Vector3.Distance(WorldController.Target.transform.position, spaceTransform.position)) >= distance)
			{
				Debug.Log("Target: " + WorldController.Target.tag); 
				
				spaceTransform.LookAt(WorldController.Target.transform);
				spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
			}
			else
			{
				//if gazing and you are closer than .4f stop
			}
		}
		else
		{
			//Move Home
			if (Vector3.Distance(spaceTransform.position, origin.position) < .1f)
			{
				//stop
				
			}else
			{
				spaceTransform.LookAt(origin.transform);
				spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
			}
			
		}
	}

	public void PlaySound(){

		playerSound.clip = SaberOn;
		playerSound.Play ();
	}
	
	public void OnHold()
	{
		//GetComponent<MetaBody>().hudLockRotation = true;
		spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
		
	}
	//    public void OnTouchDwell()
	//    {
	//        spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
	//    }
}