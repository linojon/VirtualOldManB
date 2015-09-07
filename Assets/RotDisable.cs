//This script disables the gameobject once it meets the max and min rotations

using UnityEngine;
using System.Collections;

public class RotDisable : MonoBehaviour {
	public Vector3 minRoation;
	public Vector3 maxRoation;
	public Transform head;
	public GameObject disableObject;

	CardboardHead cardboardHead;


	// Use this for initialization
	void Start () {

		cardboardHead = Camera.main.GetComponent<StereoController>().Head;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (cardboardHead.transform.rotation.y > maxRoation.y||cardboardHead.transform.rotation.y < minRoation.y ) {
	
			disableObject.SetActive(true);

		} else {
			disableObject.SetActive(false);

		}
	
	}
}
