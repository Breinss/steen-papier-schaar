using UnityEngine;
using System.Collections;

public class BarrelBehavior : MonoBehaviour {
    float rotationSpeed;
    Quaternion rotation;

	// Use this for initialization
	void Start () {
        rotationSpeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
	}
}
