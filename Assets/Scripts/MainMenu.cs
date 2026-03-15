using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); 
    }

    public void OpenInstructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
}