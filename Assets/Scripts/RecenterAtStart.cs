using UnityEngine;
using System.Collections;

public class RecenterAtStart : MonoBehaviour {

	public Cardboard _cardboard;
	public float movieTime;
	public string sceneName;
	public GameObject LoadingText;
	public GameObject[] OtherObjects;
	public MediaPlayerCtrl videoSettings;

	AsyncOperation async;

	// Use this for initialization
	void Start(){
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		_cardboard.Recenter ();
		StartCoroutine (Load());
	}

	IEnumerator Load(){

		async = Application.LoadLevelAsync(sceneName);
		async.allowSceneActivation = false;
		while (!async.isDone) {
			yield return null; 
		}


	}
	
	public void continueGame(){
		StartCoroutine (Fade ());
	}
	IEnumerator Fade(){
		videoSettings.Stop();
		videoSettings.UnLoad ();
		videoSettings.gameObject.SetActive (false);

		foreach(GameObject obj in OtherObjects){
			obj.SetActive(false);
		}
		while (LoadingText.GetComponent<CanvasGroup> ().alpha!=1) {
			LoadingText.GetComponent<CanvasGroup> ().alpha = LoadingText.GetComponent<CanvasGroup> ().alpha + Time.deltaTime / 2;
			yield return null;
		}

		async.allowSceneActivation = true;
	}
}
