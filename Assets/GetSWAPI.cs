using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;

public class GetSWAPI : MonoBehaviour {

    string baseURL = "http://swapi.co/api/planets/1/";
    public Text nameText, climateText, terrainText, populationText, gravityText;
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
        nameText.text = planet.GetField("name").ToString().Trim('"');
        climateText.text = planet.GetField("climate").ToString().Trim('"');
        terrainText.text = planet.GetField("terrain").ToString().Trim('"');
        populationText.text = planet.GetField("population").ToString().Trim('"');
        gravityText.text = planet.GetField("gravity").ToString().Trim('"');
	}

    
}
