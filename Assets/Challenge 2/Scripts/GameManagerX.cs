using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerX : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject scoreBackground;
    public GameObject timerBackground;
    public GameObject gameOverText;
    public GameObject powerUpText;
    public GameObject restartButton;
    public TextMeshProUGUI finalScoreText;

    public bool isGameActive;
    private int score;
    private float timeLeft = 60.0f;
    private bool isPowerUpActive = false;

    public static GameManagerX Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);

        if (powerUpText != null) powerUpText.SetActive(false);
        if (restartButton != null) restartButton.SetActive(false);

        if (scoreBackground != null) scoreBackground.SetActive(true);
        if (timerBackground != null) timerBackground.SetActive(true);
    }

    void Update()
    {
        if (isGameActive)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Round(timeLeft);

            if (timeLeft < 0)
            {
                GameOver();
            }
        }
    }

    public void AddScore(int scoreToAdd)
    {
        if (isPowerUpActive)
        {
            scoreToAdd *= 2;
        }

        score += scoreToAdd;
        UpdateScore(0);
    }

    public void ActivatePowerUp()
    {
        StartCoroutine(PowerUpCountdown());
    }

    IEnumerator PowerUpCountdown()
    {
        isPowerUpActive = true;
        if (powerUpText != null) powerUpText.SetActive(true);

        yield return new WaitForSeconds(7.0f);

        for (int i = 0; i < 12; i++)
        {
            if (powerUpText != null)
                powerUpText.SetActive(!powerUpText.activeSelf);

            yield return new WaitForSeconds(0.25f);
        }

        isPowerUpActive = false;
        if (powerUpText != null) powerUpText.SetActive(false);
    }

    void UpdateScore(int scoreToAdd)
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.SetActive(true);
        if (restartButton != null) restartButton.SetActive(true);

        if (finalScoreText != null)
        {
            finalScoreText.text = "Total Score: " + score;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}