using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stars : MonoBehaviour {
	public int NumOfStars = 200;
	GameObject MainCamera;
	GameObject[] GOs;

	Vector3 p1;
	Vector3 p2;
	public float Predkosc = 10f;
	void Start () {
		MainCamera = GameObject.Find("Main Camera");
		Camera camera = MainCamera.GetComponent<Camera>();
		GOs = new GameObject[NumOfStars];
		p1 = camera.ViewportToWorldPoint(new Vector3(0,0,0));
		p2 = camera.ViewportToWorldPoint(new Vector3(1,1,0));
		for(int i=0; i< NumOfStars;i++)
		{
			GOs[i] = Instantiate(Resources.Load("Prefabs/Star"), new Vector3(Random.Range(p1.x, p2.x), Random.Range(p1.y, p2.y), 0), new Quaternion() ) as GameObject;
			Star[] star = GOs[i].GetComponents<Star>();
			star[0].Spawn = p2.y+0.1f;
			star[0].Death = p1.y-0.1f;
			star[0].XMin = p1.x;
			star[0].XMax = p2.x;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Predkosc < 200f) 
			if(Input.GetKey("right"))
				Predkosc += 0.2f;
		if(Predkosc > 1f)
			if(Input.GetKey("left"))
				Predkosc -= 0.2f;
	}

}