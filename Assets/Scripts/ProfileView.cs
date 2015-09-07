using UnityEngine;
using System.Collections;

public class ProfileView : MonoBehaviour {
	public GameObject profile;
	public GameObject instructions;
	public float Distance ;
	public static GameObject currentProfile;
	public static bool tipOn = true;
	public static bool Alwayson;
	public GameObject pointer;


void Update(){

		if (Alwayson != true) {
			Distance = Vector3.Distance (transform.position, Camera.main.transform.position);
			if (Distance <= 2.2f) {
				ProfileView.currentProfile = gameObject;
				profile.SetActive (true);
				ProfileView.tipOn = false;

			}
			if (ProfileView.tipOn == true)
			if (Distance < 5 && Distance > 2.2f) {
				if (instructions != null){
					instructions.SetActive (true);	
					pointer.SetActive(true);
				}
			
			} 
			if (ProfileView.tipOn == false) {
				if (instructions != null){
					instructions.SetActive (false);	
					pointer.SetActive(false);
				}
			}
	

			if (ProfileView.currentProfile == gameObject) {
				if (Distance > 2.2) {
					ProfileView.tipOn = true;
					profile.SetActive (false);
					ProfileView.currentProfile = null;

				}

			}
		} else {
			profile.SetActive (true);
		}
	}

	public void Complete(){
		Alwayson = true;
	}

}
