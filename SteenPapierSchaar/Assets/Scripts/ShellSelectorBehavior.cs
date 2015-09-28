using UnityEngine;
using System.Collections;

public class ShellSelectorBehavior : MonoBehaviour
{
    private BarrelBehavior _barrelBehavior;
    private GameObject redShellUI;
    private GameObject greenShellUI;
    private GameObject blueShellUI;
	// Use this for initialization
	void Start ()
	{
	    _barrelBehavior = GameObject.FindWithTag("PlayerBarrel").GetComponent<BarrelBehavior>();

        redShellUI = GameObject.Find("red_shell_selector");
        greenShellUI = GameObject.Find("green_shell_selector");
        blueShellUI = GameObject.Find("blue_shell_selector");
	}
	
	// Update is called once per frame
	void Update ()
	{
        switch (_barrelBehavior.selectedShell)
        {
            case 1:
                {
                    //blue
                    transform.position = blueShellUI.transform.position + new Vector3(0.155f, -0.18f, -1f);
                    break;
                }
            case 2:
                {
                 //green   
                    transform.position = greenShellUI.transform.position + new Vector3(0.155f, -0.18f, -1f);
                    break;
                }
            case 3:
                {
                    //red
                    transform.position = redShellUI.transform.position + new Vector3(0.155f, -0.18f, -1f);
                    break;
                }
        }
	}
}
