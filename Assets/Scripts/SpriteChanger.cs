using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour {

	public Sprite Sprite1;
	public Sprite Sprite2;
	public float time;

	private Image thisImage;
	private float coutdown;
	private bool on;
	// Use this for initialization
	void Start () {
		thisImage = GetComponent<Image> ();
		coutdown = time;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!on) {
			if (coutdown > 0) {
				coutdown = coutdown - Time.deltaTime;
				thisImage.sprite = Sprite1;
			} else {
				coutdown = time;
				on = true;

			}
		}else{
			if (coutdown > 0) {
				coutdown = coutdown - Time.deltaTime;
				thisImage.sprite = Sprite2;
			} else {
				coutdown = time;
				on = false;
				
			}



			}

		}



	
	}

