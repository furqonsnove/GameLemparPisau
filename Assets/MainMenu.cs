using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NameTransfer))]
public class MainMenu : MonoBehaviour
{	
	
	

    public static MainMenu Instance { get; private set; }

    public NameTransfer NameTransfer { get; private set; }

    [SerializeField]
    private GameObject textDisplay;

    // textDisplay.GetComponent<NameTransfer>();

    public void PlayGame()
    {
    	SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
    	Debug.Log("QUIT!");
    	Application.Quit();
    }
    
}
