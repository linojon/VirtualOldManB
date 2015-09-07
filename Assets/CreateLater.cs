using UnityEngine;
using System.Collections;

public class CreateLater : MonoBehaviour {

	void LateUpdate() {
		foreach (Transform obj in transform.GetComponentInChildren<Transform>()) {
			obj.gameObject.SetActive (true);
		}


	}
}
