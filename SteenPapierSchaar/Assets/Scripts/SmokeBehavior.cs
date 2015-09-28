using UnityEngine;
using System.Collections;

public class SmokeBehavior : MonoBehaviour
{
    private SpriteRenderer opacityRenderer;
    private float opacity;

	// Use this for initialization
	void Start ()
	{
	    opacity = 1f;
	    opacityRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        opacityRenderer.color = new Color(opacityRenderer.color.r, opacityRenderer.color.g, opacityRenderer.color.b,opacity);
        Destroy(this.gameObject,2);
	}

}
