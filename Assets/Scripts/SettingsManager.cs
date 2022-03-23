using UnityEngine.SceneManagement;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void ReloadButton()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseButton()
    {
        if (Time.timeScale == 0) Time.timeScale = 1;
        else Time.timeScale = 0;
    }
}
