using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public MusicControl musicControl;
    public bool gameOver;
    bool endcont = false;

    public bool paused = false;

    public void endGame()
    {
        gameOver = true;
        musicControl.stopMusic();
    }

    void setEndControls()
    {
        endcont = true;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void doPause()
    {
        if (gameOver != true)
        {
            if (Input.GetButtonDown("Pause"))
            {
                if (paused == true)
                {
                    paused = false;
                    ResumeGame();
                }
                else
                {
                    paused = true;
                    Invoke("PauseGame", 0.05f);
                }
            }
        }
    }

    void endControls()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Restart();
        }
        if (Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        doPause();
        if (gameOver == true)
        {
            Invoke("setEndControls", 0.5f);
        }
        if (endcont == true)
        {
            endControls();
        }
    }
}
