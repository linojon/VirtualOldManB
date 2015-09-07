using UnityEngine;
using System.Collections;

public class DistroyOnEnter : MonoBehaviour {

	public float minDistance = 1;
	private float distance;

	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (transform.position, Camera.main.transform.position);
		if (distance < minDistance)
			Destroy (gameObject);
	}
}
