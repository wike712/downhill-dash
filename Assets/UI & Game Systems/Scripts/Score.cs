using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text levelText;
    public Text pauseText;
    public Text scoreLabel;
    public Text levelLabel;
    public Text gameOverText;
    public Text finalScoreText;
    public Text restartQuitText;
    public Text newHighScore;

    public ScoreKeeper scoreKeeper;
    public GameManager gameManager;
    public SpawnCars spawnCars;

    void FixedUpdate()
    {
        if (gameManager.gameOver == true)
        {
            if (scoreKeeper.score > PlayerPrefs.GetFloat("highscore"))
            {
                PlayerPrefs.SetFloat("highscore", float.Parse(scoreKeeper.score.ToString("0")));
                newHighScore.text = "New High Score!!";
            }
            gameOverText.text = "GAME OVER";
            finalScoreText.text = "Your Score: " + scoreKeeper.score.ToString("0") + "0";
            restartQuitText.text = "'Jump' - Restart 'Pause' - Quit";
            scoreLabel.text = "";
            levelLabel.text = "";
            scoreText.text = "";
            levelText.text = "";
        }
        if (gameManager.gameOver == false)
        {
            gameOverText.text = "";
            finalScoreText.text = "";
            restartQuitText.text = "";
            scoreLabel.text = "Score";
            levelLabel.text = "Level";
            scoreText.text = scoreKeeper.score.ToString("0") + "0";
            levelText.text = scoreKeeper.level.ToString();
        }
        if (gameManager.paused == true)
        {
            pauseText.text = "PAUSE";
        }
        else
        {
            pauseText.text = "";
        }
    }
}
