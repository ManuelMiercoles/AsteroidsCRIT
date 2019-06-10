using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour {
    public GameObject Splash;
    public GameObject Menu;
   // public GameObject Menu;
    
    // Use this for initialization
  void start() {

        Menu.gameObject.SetActive(false);
        // Splash.gameObject.SetActive(true);
        Invoke("Destroy", 5f);
       /* new WaitForSeconds(5);
        Menu.gameObject.SetActive(true);
        Splash.gameObject.SetActive(false);*/

    }
	
    void Destroy()
    {
        // Menu.gameObject.SetActive(true);
        Destroy(Splash);
        Menu.gameObject.SetActive(true);
    }
	// Update is called once per frame
	/*IEnumerator SplashLoad() {
        
        yield return new WaitForSeconds(5);
        Menu.gameObject.SetActive(true);
        Splash.gameObject.SetActive(false);



		
	}*/
}
