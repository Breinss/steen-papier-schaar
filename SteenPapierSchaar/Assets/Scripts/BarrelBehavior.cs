using UnityEngine;
using System.Collections;

public class BarrelBehavior : MonoBehaviour {
    public float rotationSpeed;
    Quaternion rotation;
    private GameObject clone;
    private GameObject shell;
    private bool ready;
    public int selectedShell;
    private GameObject _reloadUI;

	// Use this for initialization
	void Start ()
	{
        _reloadUI = GameObject.Find("Reload");
	    selectedShell = 1;
	    ready = true;
        rotationSpeed = .8f;
        _reloadUI.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up * 5f), Color.black);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

        switch (selectedShell)
	    {
            case 1: 
	        {
                shell = Resources.Load("blue_shell") as GameObject;
                break;
	        }
            case 2:
	        {
                shell = Resources.Load("green_shell") as GameObject;
	            break;
	        }
            case 3:
	        {
                shell = Resources.Load("red_shell") as GameObject;
	            break;
	        }
	    }
        if (Input.GetButtonDown("Fire1"))
        {
            if (ready)
            {
                StartCoroutine(WaitForReload());
            }
        }

        if(Input.GetKeyUp("1"))
        {
            selectedShell = 1;
        }
        if (Input.GetKeyUp("2"))
        {
            selectedShell = 2;
        }
        if (Input.GetKeyUp("3"))
        {
            selectedShell = 3;
        }

	}

    IEnumerator WaitForReload()
    {
        ready = false;
        clone = Instantiate(shell, transform.position + new Vector3(0, 0, 0.2f), transform.rotation) as GameObject;
        _reloadUI.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        _reloadUI.gameObject.SetActive(false);
        ready = true;
    }
    void OnMouseDown()
    {

    }
	public void addPoints(){
		rotationSpeed += 1f;
	}
}
