using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GoPlayGame : MonoBehaviour
{
    public void CallGame()
    {
    	SceneManager.LoadScene(2);
    }
}
