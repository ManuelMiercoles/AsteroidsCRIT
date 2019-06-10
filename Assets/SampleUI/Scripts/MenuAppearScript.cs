using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAppearScript : MonoBehaviour {

    public GameObject menu; // Assign in inspector
    private bool isShowing;
    public GameObject MainMenu;

    void Update()
    {
       if (Input.GetKeyDown("escape")) 
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
            MainMenu.SetActive(true);
        }
        
        if (Input.GetButtonDown("Cancel")) 
            {
                isShowing = !isShowing;
                menu.SetActive(isShowing);
                MainMenu.SetActive(true);
            }
        }
    }

