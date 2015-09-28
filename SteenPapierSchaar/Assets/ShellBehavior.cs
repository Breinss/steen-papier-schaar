using UnityEngine;
using System.Collections;

public class ShellBehavior : MonoBehaviour
{
    private Vector3 lineOffset;
    private Rigidbody2D _rigidbody2D;
    public bool _hit;

    private GameObject smokeClone;
    private GameObject smoke;
	// Use this for initialization
	void Start ()
	{
        smoke = Resources.Load("smoke") as GameObject;
	    _rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
    void Update()
	{
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up * .13f), Color.black);
        _rigidbody2D.velocity = transform.TransformDirection(Vector3.up * 2);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector3.up * 1),.13f);
        Destroy(this.gameObject,10);
        if (hit.collider != null )
        {
            if (hit.collider.name == "Enemy")
            {
                
                smokeClone = Instantiate(smoke, transform.position + new Vector3(0, 0, 0.2f), transform.rotation) as GameObject;
                Destroy(this.gameObject);
            }
        }
	}
}
