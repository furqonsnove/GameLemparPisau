using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private GameObject restartButton;
    [SerializeField]
    private GameObject menuButton;

    [Header("Knife Count Display")]
    [SerializeField]
    private GameObject panelKnives;
    [SerializeField]
    private GameObject iconKnife;
    [SerializeField]
    private GameObject scoreText;
    [SerializeField]
    private Color usedKnifeIconColor;
    private int score;

    public void ShowButton() {
        restartButton.SetActive(true);
        menuButton.SetActive(true);
    }



    public void SetInitialDisplayedKnifeCount(int count) {
        for (int i=0;i<count;i++){
            Instantiate(iconKnife, panelKnives.transform);
        }
    }   

    private int knifeIconIndexToChange = 0;
    public void DecrementDisplayedKnifeCount() {
        panelKnives.transform.GetChild(knifeIconIndexToChange++)
            .GetComponent<Image>().color = usedKnifeIconColor;
    }

    public void SetScoreText(int skor) {
    	scoreText.GetComponent<Text>().text = "Score : " + skor;
    }

    public void UpdateScore() {
    	score += 1;
    	SetScoreText(score);
    }
}
