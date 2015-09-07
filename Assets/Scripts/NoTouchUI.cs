using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NoTouchUI : MonoBehaviour {

	private PointerEventData eventSystem;
	private  EventSystem EventSystemManager;
	public GameObject loader;
	private Image loadFill;
	private float fillAmount = 0;
	CardboardHead cardboardHead;
	GazeInputModule gazeInput;


	// Use this for initialization
	void Start () {
		cardboardHead = Camera.main.GetComponent<StereoController>().Head;
		gazeInput = GameObject.FindGameObjectWithTag ("EventSystem").GetComponent<GazeInputModule>();
	EventSystemManager = GameObject.FindGameObjectWithTag ("EventSystem").GetComponent<EventSystem> ();
	eventSystem = new PointerEventData (EventSystem.current);
	loader = GameObject.FindGameObjectWithTag ("Clicker");
		loadFill = loader.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (EventSystemManager.IsPointerOverGameObject ()) {
			loader.SetActive (true);
			fillAmount = fillAmount+ Time.deltaTime/2;
			loader.GetComponent<Image>().fillAmount = fillAmount;
			
		
		if(fillAmount >= 1){
				gazeInput.CodeTrigger();
				fillAmount = 0;
			}


		} else {
			loader.SetActive(false);
			fillAmount = 0;

		}
	
	}
}
