using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clicker : MonoBehaviour {


	void OnDisable() {
		GetComponent<Image> ().fillAmount = 0;
	}
}
