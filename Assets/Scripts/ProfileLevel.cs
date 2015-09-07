using UnityEngine;
using System.Collections;

public class ProfileLevel : MonoBehaviour {
	public enum FaceLevel{faceOne,faceTwo,faceThree};

	public FaceLevel level;
	public GameObject level1;
	public GameObject level2;
	public GameObject level3;


	public void FaceDetail(){
		switch (level) {
		case FaceLevel.faceOne:
			level1.SetActive(true);
			break;
		case FaceLevel.faceTwo:
			level2.SetActive(true);
			break;
		case FaceLevel.faceThree:
			level1.SetActive(false);
			level2.SetActive(false);
			level3.SetActive(true);
			break;

		}

	}
}
