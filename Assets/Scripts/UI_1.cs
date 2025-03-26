using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_1 : MonoBehaviour
{
    public Button playButton;
    public Button helpButton;
    public Button exitButton;
    public Button creditsButton;
    public Button game1Button;
    public Button backButton;

    public void Start()
    {
        playButton.onClick.AddListener(Play);
        game1Button.onClick.AddListener(Game1);
        backButton.onClick.AddListener(Back);
    }
    public void Play()
    {
        game1Button.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);

        playButton.gameObject.SetActive(false);
        helpButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        creditsButton.gameObject.SetActive(false);
    }

    public void Game1()
    {
        SceneManager.LoadScene("1_1");
    }

    public void Back()
    {
        game1Button.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);

        playButton.gameObject.SetActive(true);
        helpButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        creditsButton.gameObject.SetActive(true);
    }
    
}
