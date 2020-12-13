using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public GameObject InstructionsMenu;

    public GameObject LevelsMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(false);
        CreditsMenu.SetActive(true);
        LevelsMenu.SetActive(false);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        InstructionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
        LevelsMenu.SetActive(false);
    }


    public void InstructionsMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        LevelsMenu.SetActive(false);
    }

    public void LevelsMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
        LevelsMenu.SetActive(true);
    }

    public void Level1Button()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }

    public void Level2Button()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }

    public void Level3Button()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
    }

    public void Level4Button()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level4");
    }

    public void Level5Button()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level5");
    }

    public void BackToMainMenuButton()
    {
        // Play Now Button has been pressed, here you can initialize your game
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}