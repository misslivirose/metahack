using UnityEngine;
using System.Collections;
public class MoveSolarSystem : MonoBehaviour
{
    public Transform spaceTransform;
    public Transform origin;
    public float speed = .3f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WorldController.gazing)
        {
            //if not .4 away; Vector between curpos and origin< .4 
            //Debug.Log("Target: " + WorldController.Target.tag); 
            float x;
            if (WorldController.Target != null && (x = Vector3.Distance(WorldController.Target.transform.position, spaceTransform.position)) > .4f)
            {
                spaceTransform.LookAt(WorldController.Target.transform);
                spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
        }
        else
        {
            //Move Home
            spaceTransform.LookAt(origin.transform);
            spaceTransform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
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