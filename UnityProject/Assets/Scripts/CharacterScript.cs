using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

	private ActivatedObject activeObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			if(activeObject != null){
				activeObject.activateAction();
			}
		}
	}

	public void setActiveObject(ActivatedObject obj){
		this.activeObject = obj;
	}

	public void resetActiveObject(ActivatedObject obj){
		if(obj == activeObject)
			activeObject = null;
	}
}
