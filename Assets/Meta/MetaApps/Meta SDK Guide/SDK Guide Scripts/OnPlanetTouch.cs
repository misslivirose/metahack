using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Meta;
public class OnPlanetTouch : MonoBehaviour
{
    string baseURL = "http://swapi.co/api/planets/";
    public Text nameText, climateText, terrainText, populationText, gravityText;
	//public MoveSolarSystem movement; 
    // Use this for initialization
	private MoveSolarSystem movement;
    void Start()
    {
		 movement = GetComponent <MoveSolarSystem> ();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTouchDwell()
    {
        //renderer.material.color = Color.cyan;
        string s = gameObject.tag;
        Debug.Log("Getting planet: " + s);
        StartCoroutine(DownloadPlanet(s));
        Debug.Log("Was Dwelled" + s);
		movement.PlaySound ();


    }
    public void OnGazeDwell()
    {
        Debug.Log("Gazing");
        WorldController.gazing = true;
        WorldController.Target = (GameObject)this.gameObject;
    }
    public void OnGazeDwellExit()
    {
        Debug.Log("Stopped Gazing");
        WorldController.gazing = false;
        WorldController.Target = null;
    }
    IEnumerator DownloadPlanet(string s)
    {
        // Update this to use the proper input method from Meta, i.e. "onClick" equivalent
        // Grab the tag and append it to the baseURL, i.e. baseURL + "this.Tag"
        WWW w = new WWW(baseURL + s);
        yield return w;
        yield return new WaitForSeconds(1f);
        Debug.Log("Received planet");
        ExtractPlanetData(w.text);
    }
    void ExtractPlanetData(string json_planet)
    {
        JSONObject planet = new JSONObject(json_planet);
        nameText.text = planet.GetField("name").ToString().Trim('"');
        climateText.text = planet.GetField("climate").ToString().Trim('"');
        terrainText.text = planet.GetField("terrain").ToString().Trim('"');
        populationText.text = planet.GetField("population").ToString().Trim('"');
        gravityText.text = planet.GetField("gravity").ToString().Trim('"');
    }
    //public void OnGazeHold(){
    //	Debug.Log ("Gazing");
    //}
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