using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    public GameObject Player;
    public GameObject ScoreToDisplay;

	public void Pause ()
    {
        Time.timeScale = 0.0f;
    }

    public void Play ()
    {
        Time.timeScale = 1f;
    }

    public void Retry ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void DisPlayScore()
    {
        int score = (int)Player.GetComponent<PlayerController>().distanceScore;
        ScoreToDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
