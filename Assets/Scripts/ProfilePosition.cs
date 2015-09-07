using UnityEngine;
using System.Collections;

public class ProfilePosition : MonoBehaviour {
	public Transform Player;

	// Use this for initialization
	void Update(){
		transform.position = new Vector3 (Player.position.x + 5.79421f, Player.position.y + 2.9f, Player.position.z + 1.05f);

	}
}
