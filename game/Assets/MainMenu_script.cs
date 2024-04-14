using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu_script : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditsMenu;


    // Start is called before the first frame update
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        SceneManager.LoadScene("GameScene");

    }

    public void GoToCredits()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
        //SceneManager.LoadScene("CreditsMenu");
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }
    public void GoToMainMenu()
    {
        creditsMenu.SetActive(false);
        SceneManager.LoadScene("MainScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
