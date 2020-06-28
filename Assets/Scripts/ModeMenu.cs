using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeMenu : MonoBehaviour
{
    public void EnterSelection() {
        SceneManager.LoadScene("GameLobby");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
