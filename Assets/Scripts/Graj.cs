using UnityEngine;
using System.Collections;
using System.Linq;

public class Graj : MonoBehaviour {

	// Use this for initialization
	public GUISkin skin;
	public Texture2D tex1;
	public Texture2D tex2;
	Rect grajRect;
	Rect opcjeRect;
	Rect wyjdzRect;
	float timerG = 0f;
	float timerO = 0f;
	float timerW = 0f;

	float originalWidth = 1280.0f;  // define here the original resolution
	float originalHeight = 720.0f; // you used to create the GUI contents 
	private Vector3 scale;

	void Start () {
		grajRect =  new Rect(originalWidth+125, 	originalHeight*4/8 -25, 250, 75);
		opcjeRect = new Rect(			-275,	originalHeight*5/8 -25, 250, 75);
		wyjdzRect = new Rect(originalWidth+125, 	originalHeight*6/8 -25, 250, 75);
	}
	
	// Update is called once per frame
	void Update () {

		if(timerG >= 0.8f)
			grajRect.position = Vector2.Lerp(grajRect.position, new Vector2((originalWidth/2-125), (originalHeight*4/8-37)), Time.deltaTime*4);
		else
			timerG += Time.deltaTime;


		if(timerO >= 0.9f)
			opcjeRect.position = Vector2.Lerp(opcjeRect.position, new Vector2(originalWidth/2-125, originalHeight*5/8-37), Time.deltaTime*4);
		else
			timerO += Time.deltaTime;

		if(timerW >= 1f)
			wyjdzRect.position = Vector2.Lerp(wyjdzRect.position, new Vector2(originalWidth/2-125, originalHeight*6/8-37), Time.deltaTime*4);
		else
			timerW += Time.deltaTime;
	}

	/*void OnGUI()
	{
		GUI.skin = skin;
		if (GUI.Button(new Rect(Screen.width/2 - 75, Screen.height/2 - 25, 150, 50), "GRAJ"))
			Debug.Log("Clicked the button with an image");
	}
*/
	public void OnGUI()
	{
		GUI.skin = skin;
		scale.x = Screen.width/originalWidth; // calculate hor scale
		scale.y = Screen.height/originalHeight; // calculate vert scale
		scale.z = 1;
		Matrix4x4 svMat = GUI.matrix; // save current matrix
		// substitute matrix - only scale is altered from standard
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);

		if( GUI.Button(grajRect, "Graj"))
		{
			Debug.Log( "Yarrr! Clicked!" );
		}
		if( GUI.Button(opcjeRect, "Opcje"))
		{

		}
		if(GUI.Button(wyjdzRect, "Wyjdz"))
		{
			Application.Quit();
		}
		GUI.matrix = svMat; // restore matrix
	}
	


	



}
