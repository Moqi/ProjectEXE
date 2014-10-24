using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {

	// Use this for initialization
	Vector3 EndPos;
	float Timer = 0f;
	void Start () {

		EndPos = new Vector3(0.5f,0.8f,0f);
	}


	void Update () {
		if(Timer > 1.2f)
			transform.position = Vector3.Lerp(transform.position, EndPos, Time.deltaTime * 4);
		else
			Timer += Time.deltaTime;
	}
}
