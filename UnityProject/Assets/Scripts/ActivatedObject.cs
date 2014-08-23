using UnityEngine;
using System.Collections;

public class ActivatedObject : MonoBehaviour {
	public virtual void activateAction(){
		//blablabla
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		other.GetComponent<CharacterScript>().setActiveObject(this);
		Debug.Log ("trigger");
	}
	
	void OnTriggerExit2D(Collider2D other){
		other.GetComponent<CharacterScript>().resetActiveObject(this);
	}

}
