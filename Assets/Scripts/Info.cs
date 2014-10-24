using UnityEngine;
using System.Collections;

public class Info : MonoBehaviour {

	public GameObject MainCamera;
	public Camera camera;
	public Vector3 LB;//LEFT BOTTOM of camera
	public Vector3 RT;//RIGHT TOP of camera
	public float height;
	public float width;
	// Use this for initialization
	void Start () {
		//MainCamera = GameObject.Find("Main Camera");
		//camera = MainCamera.GetComponent<Camera>();
		camera = Camera.main;
		LB = camera.ViewportToWorldPoint(new Vector3(0,0,0));
		RT = camera.ViewportToWorldPoint(new Vector3(1,1,0));
		height = 2f * camera.orthographicSize;
		width = height * camera.aspect;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
