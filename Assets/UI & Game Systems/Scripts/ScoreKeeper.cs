using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public Transform player;
    public float score;
    public int level = 1;
    public float holeTimerHigh = 5;
    public float carTimerHigh = 4;
    public float carSpeed = 12;
    public int carSpawnLow;
    public int carSpawnHigh;
    public int holeSpawnLow;
    public int holeSpawnHigh;
    public int carsDodged;
    public float timer = 24;


    void calculateScore()
    {
        if (
        FindObjectOfType<GameManager>().gameOver == false)
        {
            score = score + 1 * Time.deltaTime;
        }
    }

    void levelUp()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            level++;
            timer = 24;
        }

    }

    void calculateSpawn()
    {
        if (holeTimerHigh > 1)
        {
            holeTimerHigh = (5 - (level * 0.2f));
        }
        if (carTimerHigh > 0.9f)
        {
            carTimerHigh = (4 - (level * 0.2f));
        }
    }

    void calculateCarSpeed()
    {
        if (carSpeed < 15)
        {
            carSpeed = (12 + level * 0.7f);
        }
    }

    void calculateCarSpawnLevel()
    {
        if (level == 1)
        {
            carSpawnLow = 0;
            carSpawnHigh = 2;
        }
        if (level == 2)
        {
            carSpawnLow = 0;
            carSpawnHigh = 4;
        }
        if (level == 3)
        {
            carSpawnLow = 3;
            carSpawnHigh = 7;
        }
        if (level == 4)
        {
            carSpawnLow = 3;
            carSpawnHigh = 10;
        }
        if (level == 5)
        {
            carSpawnLow = 5;
            carSpawnHigh = 11;
        }
        if (level == 6)
        {
            carSpawnLow = 5;
            carSpawnHigh = 13;
        }
        if (level == 7)
        {
            carSpawnLow = 5;
            carSpawnHigh = 16;
        }
        if (level == 8)
        {
            carSpawnLow = 5;
            carSpawnHigh = 17;
        }
        if (level == 9)
        {
            carSpawnLow = 5;
            carSpawnHigh = 19;
        }
        if (level >= 10)
        {
            carSpawnLow = 5;
            carSpawnHigh = 21;
        }
    }

    void calculateHoleSpawnLevel()
    {
        if (level > 1 && level <= 4)
        {
            holeSpawnLow = 0;
            holeSpawnHigh = 2;
        }
        if (level > 4 && level <= 7)
        {
            holeSpawnLow = 0;
            holeSpawnHigh = 5;
        }
        if (level > 7 && level <= 9)
        {
            holeSpawnLow = 0;
            holeSpawnHigh = 6;
        }
        if (level >= 10)
        {
            holeSpawnLow = 3;
            holeSpawnHigh = 6;
        }
    }

    public void goldCoin()
    {
        score = score + 10;
    }

    public void silverCoin()
    {
        score = score + 5;
    }
    public void bronzeCoin()
    {
        score = score + 2;
    }

    void FixedUpdate()
    {
        {
            calculateSpawn();
            calculateScore();
            calculateCarSpeed();
            calculateCarSpawnLevel();
            calculateHoleSpawnLevel();
            levelUp();
        }
    }
}