using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
		if (target == null)
			target = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (target.position);
	}
}
