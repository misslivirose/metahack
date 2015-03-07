##Parsing the Star Wars API
The GetSWAPI.cs file provides an interface for the GET request that is sent to the SWAPI.co site to retrieve the planet information when the user triggers a click (touch) on a specific planet. SWAPI sends back a JSON object that is then parsed by the `ExtractPlanetData()` function and displays the corresponding information (name, climate, terrain, population, and gravity) onto the on screen UI.

##Creating a Meta HMD GUI
To create a UI that utilizes the transparency present in the HMD, utilize the MGUI objects that are provided as part of the Meta SDK (MGUI.Canvas, MGUI.Panel, MGUI.Text, MGUI.Button) and access them the way you would any regular Unity UI object. Creating references as typical Text objects in scripts using the UnityEngine.UI declarative will allow you to set items to MGUI items in the Inspector without specifically specifying the MGUI type in the script.

Planet Bitmaps: http://freebitmaps.blogspot.com/2010/10/srgb-planet-dante.html
