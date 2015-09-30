using UnityEngine;
using System.Collections;

public class MinionMouseInteraction : MonoBehaviour {

	private Vector3 mousePos;
	private Vector3 oldMousePos;
	private Vector2 LastPos;
	private Rigidbody2D _rigidBody2D;
	// Use this for initialization
	void Start () {
		_rigidBody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update(){


	}
	void FixedUpdate()
	{

	}
	void OnMouseDown()
	{
	
		
	}
	void OnMouseDrag() {
		Vector3 pos = Input.mousePosition;
		pos.z = transform.position.z - Camera.main.transform.position.z;
		transform.position = Camera.main.ScreenToWorldPoint(pos);
	}
	void OnMouseUp(){
		_rigidBody2D.velocity = (_rigidBody2D.position - LastPos) / Time.deltaTime;
		LastPos = _rigidBody2D.position;
		if (_rigidBody2D.velocity.sqrMagnitude > 10f) {
			_rigidBody2D.velocity = _rigidBody2D.velocity.normalized * 10f;
		}
	}
}
