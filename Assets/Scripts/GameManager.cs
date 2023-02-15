using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Player player;
    public Text txtScore;
    public GameObject btnPlay;
    public GameObject imgGameOver;
    public GameObject imgGetReady;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {
        score = 0;
        txtScore.text = score.ToString();
         
        btnPlay.SetActive(false);
        imgGameOver.SetActive(false);
        imgGetReady.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {

        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {

        score++;
        txtScore.text = score.ToString();
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        imgGameOver.SetActive(true);
        btnPlay.SetActive(true);

        Pause();
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
