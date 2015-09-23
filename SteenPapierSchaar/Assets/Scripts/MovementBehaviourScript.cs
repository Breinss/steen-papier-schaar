using UnityEngine;
using System.Collections;

public class MovementBehaviourScript : MonoBehaviour
{
    public Vector2 velocity;
    public float Speed = 1f;
    public float turnSpeed = 50f;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (Input.GetKey(KeyCode.W))
	    {
            transform.Translate(0, Speed * Time.deltaTime, 0);
	    }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(Vector3.forward * -turnSpeed * Time.deltaTime * 5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.forward * -turnSpeed * Time.deltaTime * 5f);
        }
	}
}
