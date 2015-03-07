using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;

public class GetSWAPI : MonoBehaviour {

    string baseURL = "http://swapi.co/api/planets/1/";
    public Text textbox;
	IEnumerator DownloadPlanet()
	{
		// Pull down the JSON from our web-service
		
        // Update this to use the proper input method from Meta, i.e. "onClick" equivalent
        // Grab the tag and append it to the baseURL, i.e. baseURL + "this.Tag" 
		WWW w = new WWW(baseURL);
		yield return w;
        yield return new WaitForSeconds(1f);
        Debug.Log("Received planet");
		ExtractPlanetData(w.text);
	}
	void Start ()
	{
        print("Started planet import...\n");
		StartCoroutine(DownloadPlanet());
	}
	void ExtractPlanetData(string json_planet)
	{
		JSONObject planet = new JSONObject (json_planet);

        JSONObject planetName = planet.GetField("name");
        textbox.text = planetName.ToString();

        Debug.Log("Name of planet: " + planetName.ToString());
	}
}
