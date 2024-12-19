using UnityEngine;
using UnityEngine.SceneManagement;

public class StartQuit : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
}
