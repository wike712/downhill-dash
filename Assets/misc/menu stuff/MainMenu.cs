using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text hss;
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        //PlayerPrefs.SetFloat("highscore", 0);
        hss.text = "High Score: " + PlayerPrefs.GetFloat("highscore").ToString() + "0";
    }

    void Update()
    {

    }
}
