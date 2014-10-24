using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
	public float z = 10f;
	public float pr = 10f;
	public float Skalar = 0.7f;
	public float Spawn = 0f;
	public float Death = 1f;
	public float XMin = 0f;
	public float XMax = 1f;
	public float NearStars = 15f;
	public float FarStars = 140f;

	GameObject Father;
	Stars FatherStars;

	void Start () {
		Father = GameObject.Find("Stars Father");
		FatherStars = Father.GetComponent<Stars>() as Stars;
		z = Random.Range(NearStars,FarStars);
		transform.localScale = new Vector3(Skalar/z,Skalar/z,0);
		transform.parent = Father.transform;
	}

	// Update is called once per frame
	void Update () {
		pr = FatherStars.Predkosc;
		transform.position += Vector3.down * ( 2*(1/z) * Time.deltaTime) * pr;
		if(transform.position.y <= Death)
		{
			Init();
		}
	}

	public void Init()
	{
		z = Random.Range(NearStars,FarStars);
		//                                     X                      	 Y                      Z
		transform.localScale = new Vector3(Skalar/z,             	   Skalar/z,             0);
		transform.position   = new Vector3(transform.position.x, 	   Spawn,                transform.position.z);// Y
		transform.position   = new Vector3(Random.Range(XMin,XMax),    transform.position.y, transform.position.z);
	}
}
