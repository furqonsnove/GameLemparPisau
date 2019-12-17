using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameUI))]
public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    [SerializeField]
    public int life;
    [SerializeField]
    private int score;

    [Header("Knife Spawning")]
    [SerializeField]
    private Vector2 knifeSpawnPosition;
    [SerializeField]
    private GameObject knifeObject;

    public GameUI GameUI { get; private set; }

    private void Awake() {
        Instance = this;
        score = 0;
        GameUI = GetComponent<GameUI>();
        GameUI.SetScoreText(score);
    }

    private void Start() {
        GameUI.SetInitialDisplayedKnifeCount(life);
        SpawnKnife();
    }

    public void OnSuccessfulKnifeHit() {
    	GameUI.UpdateScore();
        score += 1;
        SpawnKnife();
    }

    private void SpawnKnife() {
        Instantiate(knifeObject, knifeSpawnPosition, Quaternion.identity);
    }

    public void WaitSpawn(){
        StartCoroutine("WaitSpawnCoroutine");
    }

    private IEnumerator WaitSpawnCoroutine() {
        yield return new WaitForSecondsRealtime(1.5f);
        life--;
        GameUI.DecrementDisplayedKnifeCount();
        SpawnKnife();
    }

    public void StartGameOverSequence() {
        GameUI.ShowButton();
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

    public void MenuGame() {
    	SceneManager.LoadScene(0);
    }
}
