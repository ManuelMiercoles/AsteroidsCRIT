using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject1;
    /*
    public GameObject selectedObject2;
    public GameObject selectedObject3;
    public GameObject selectedObject4;
    public GameObject selectedObject5;
    */
    private bool buttonSelected;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            eventSystem.SetSelectedGameObject(selectedObject1);
            buttonSelected = true;
        }
       /* else if (Input.GetAxisRaw("Vertical") != 0)
        {
                eventSystem.SetSelectedGameObject(selectedObject2);
                buttonSelected = true;
            }
        else if (Input.GetAxisRaw("Vertical") != 1)
        {
            eventSystem.SetSelectedGameObject(selectedObject3);
            buttonSelected = true;
        }
        else if (Input.GetAxisRaw("Vertical") != 1)
        {
            eventSystem.SetSelectedGameObject(selectedObject4);
            buttonSelected = true;
        }
        else if (Input.GetAxisRaw("Vertical") != 1)
        {
            eventSystem.SetSelectedGameObject(selectedObject5);
            buttonSelected = true;
        }
        */

    }
    private void OnDisable()
    {
        buttonSelected = false;
    }
}
