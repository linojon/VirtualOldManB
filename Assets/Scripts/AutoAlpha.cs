using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AutoAlpha : MonoBehaviour {

	float alpha = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		alpha = alpha - Time.deltaTime;
		GetComponent<CanvasGroup> ().alpha = alpha ;
	}
}
