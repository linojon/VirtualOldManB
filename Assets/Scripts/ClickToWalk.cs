using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class ClickToWalk : MonoBehaviour {

	//This is used for the raycast walking system
	public Transform myCam;
	public Transform head;

	public EventSystem EventSystemManager;

	//This is used for the Look To Walk system
	CardboardHead cardboardHead;



	void Start(){
		//We get the head componant from google
		cardboardHead = Camera.main.GetComponent<StereoController>().Head;

		//We precvent devices such as the LG G2 from going to sleep
		Screen.sleepTimeout = SleepTimeout.NeverSleep;

	}

	void Update () {
		//Detects trigger pull, or on the new google cardboards, a tap

		if (Cardboard.SDK.Triggered) {
			Ray ray = new Ray (myCam.position, myCam.forward);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100)) {

				//This triggers the raycast walking
				if (hit.transform.tag == "Terrain") {
					StopAllCoroutines ();
					StartCoroutine (MoveTo (hit.point));
				} else {
					if (!EventSystemManager.IsPointerOverGameObject ()) {
						// This triggers the more simple walk forward
						StopAllCoroutines ();
						StartCoroutine (MoveForward ());
					}
			
				}
			}
		}
	}

	IEnumerator MoveTo(Vector3 Location){
		GetComponent<Rigidbody> ().useGravity = true;
		//We don't want to go to the ground so we will keep our character leveled
		Location.y = transform.position.y;

		while (Vector3.Distance(transform.position,Location) >.3f) {
		float step = Time.deltaTime*2f;
		transform.position= Vector3.MoveTowards (transform.position, Location, step);
			yield return null;
		}
		GetComponent<Rigidbody> ().useGravity = false;

	}

	IEnumerator MoveForward(){
		GetComponent<Rigidbody> ().useGravity = true;
		float steps = 0;
		//These set the positions for the walk forward. If you were to move this into the while statement you would walk where you look
		Vector3 direction = new Vector3(cardboardHead.transform.forward.x, 0, cardboardHead.transform.forward.z).normalized * 2 * Time.deltaTime;
		Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
		while (steps<2) {
			transform.Translate(rotation * direction);
			steps = steps + Time.deltaTime;
			yield return null;
		}
		GetComponent<Rigidbody> ().useGravity = false;
	}
	}

