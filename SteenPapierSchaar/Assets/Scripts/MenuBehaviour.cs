using UnityEngine;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {
	private GameObject shopMenu;
	private bool isShowing;
	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		isShowing = false;
		shopMenu = GameObject.Find ("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if(!isShowing){
				isShowing = true;
				Cursor.visible = isShowing;

			}
			else{
				isShowing = false;
				Cursor.visible = isShowing;
			}
			shopMenu.SetActive(isShowing);

		}
	}
}
