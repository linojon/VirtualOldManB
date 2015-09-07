using UnityEngine;
using System.Collections;

public class timedDestroy : MonoBehaviour {

	public float time;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (time > 0) {
			time = time - Time.deltaTime;
		} else {
			Destroy(gameObject);
		}

	}
}
