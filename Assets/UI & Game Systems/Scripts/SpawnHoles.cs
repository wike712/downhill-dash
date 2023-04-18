using UnityEngine;

public class SpawnHoles : MonoBehaviour
{
    public GameObject HolePrefab;
    public GameObject SilverCoinPrefab;
    public ScoreKeeper scoreKeeper;
    public GameManager gameManager;
    bool coin = false;
    float timer;
    int holePos;
    float level;

    void doSpawnHoles()
    {
        timer = Random.Range(0.5f, scoreKeeper.holeTimerHigh);
        holePos = Random.Range(scoreKeeper.holeSpawnLow, scoreKeeper.holeSpawnHigh + 1);
        if (holePos == 0)
        {
            Vector3 myPosition = new Vector3(-2.1f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(-2.1f, 1.545f, 100);
                GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
        if (holePos == 1)
        {
            Vector3 myPosition = new Vector3(-0.1f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(-0.1f, 1.545f, 100);
                GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
                spawnCoin();
            }
            coin = false;
        }
        if (holePos == 2)
        {
            Vector3 myPosition = new Vector3(1.9f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(1.9f, 1.545f, 100);
                GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
        if (holePos == 3)
        {
            Vector3 myPosition = new Vector3(-2.1f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            Vector3 myPosition2 = new Vector3(-0.1f, 0.045f, 100);
            GameObject hole2 = Instantiate(HolePrefab, myPosition2, Quaternion.identity);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(-2.1f, 1.545f, 100);
                GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
        if (holePos == 4)
        {
            Vector3 myPosition = new Vector3(-0.1f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            Vector3 myPosition2 = new Vector3(1.9f, 0.045f, 100);
            GameObject hole2 = Instantiate(HolePrefab, myPosition2, Quaternion.identity);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(1.9f, 1.545f, 100);
                GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
        if (holePos == 5)
        {
            Vector3 myPosition = new Vector3(-2.1f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            Vector3 myPosition2 = new Vector3(1.9f, 0.045f, 100);
            GameObject hole2 = Instantiate(HolePrefab, myPosition2, Quaternion.identity);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(-0.1f, 1.145f, 100);
                GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }

        if (holePos == 6)
        {
            Vector3 myPosition = new Vector3(-2.1f, 0.045f, 100);
            GameObject hole = Instantiate(HolePrefab, myPosition, Quaternion.identity);
            Vector3 myPosition2 = new Vector3(-0.1f, 0.045f, 100);
            GameObject hole2 = Instantiate(HolePrefab, myPosition2, Quaternion.identity);
            Vector3 myPosition3 = new Vector3(1.9f, 0.045f, 100);
            GameObject hole3 = Instantiate(HolePrefab, myPosition3, Quaternion.identity);
            spawnCoin();
            if (coin == true)
            {
                int coinPos = Random.Range(0, 3);
                if (coinPos == 0)
                {
                    Vector3 coinPosition = new Vector3(-2.1f, 1.545f, 100);
                    GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
                }
                if (coinPos == 1)
                {
                    Vector3 coinPosition = new Vector3(-0.1f, 1.545f, 100);
                    GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
                }
                if (coinPos == 2)
                {
                    Vector3 coinPosition = new Vector3(1.9f, 1.545f, 100);
                    GameObject coin = Instantiate(SilverCoinPrefab, coinPosition, Quaternion.identity);
                }
            }
            coin = false;
        }
    }

    void spawnCoin()
    {
        int spawn = Random.Range(0, 10);
        if (spawn > 6)
        {
            coin = true;
        }
    }

    void Update()
    {
        if (gameManager.gameOver != true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                doSpawnHoles();
            }
        }
    }

}
