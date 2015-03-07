using UnityEngine;
using System.Collections;
using System.Net;
using System.IO;

public class GetSWAPI : MonoBehaviour {

	IEnumerator DownloadPlanet()
	{
		// Pull down the JSON from our web-service
		
		WWW w = new WWW("http://swapi.co/api/planets/1/");
		yield return w;
        yield return new WaitForSeconds(1f);
        Debug.Log("Received planets");
		// Extract the spheres from our JSON results
		
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
		foreach (JSONObject item in planet.list)
        {
            Debug.Log("Testing");
        }
	}
}
