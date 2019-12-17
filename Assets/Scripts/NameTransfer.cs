using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject inputFieldNYA;
    public GameObject entername;
    public GameObject textDisplay;
    public GameObject buttonMenu;
    public GameObject enterMenu;
  
    
    

    public void StoreName()
    {
    	theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + theName + " to the game";
        buttonMenu.SetActive(true);
        enterMenu.SetActive(false);
        inputFieldNYA.SetActive(false);
        entername.SetActive(false);
        textDisplay.SetActive(true);
    }

    public void CallMenu()
    {
        SceneManager.LoadScene(1);
    }

   

    
}
