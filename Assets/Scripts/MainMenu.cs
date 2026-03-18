using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
           
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("BlaiseScene"); 
    }

    public void OpenInstructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu"); 
    }
    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
    public void Death()
    {
        SceneManager.LoadScene("BlaiseScene");
    }
    
}