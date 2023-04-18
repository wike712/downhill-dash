using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject BlueCarPrefab;
    public GameObject MidRedCarPrefab;
    public GameObject MidYellowCarPrefab;
    public GameObject MoveRedCarPrefab;
    public GameObject MoveYellowCarPrefab;
    public GameObject PurpleCarPrefab;
    public GameObject PurpleCarPrefab2;
    public GameObject GoldCoinPrefab;
    public GameObject BronzeCoinPrefab;
    public GameObject Beep;
    public ScoreKeeper scoreKeeper;
    int spawnBronze;

    bool coin;

    public float timer;
    int carPos;
    bool midcar = false;


    Vector3 left = new Vector3(-2, 0.045f, 100);
    Vector3 mid = new Vector3(0, 0.045f, 100);
    Vector3 right = new Vector3(2, 0.045f, 100);
    Vector3 rightBack = new Vector3(2, 0.045f, 106);
    Vector3 leftBack = new Vector3(-2, 0.045f, 106);
    Vector3 midBack = new Vector3(0, 0.045f, 106);

    void Start()
    {
        doSpawnCars();
    }

    void Update()
    {
        if (gameManager.gameOver != true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                doSpawnCars();
            }
        }
    }

    void spawnRed()
    {
        int spawn = Random.Range(0, 2);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(MoveRedCarPrefab, myPosition, MoveRedCarPrefab.transform.rotation);
            }
        }
        if (spawn == 1)
        {
            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(MidRedCarPrefab, myPosition, MidRedCarPrefab.transform.rotation);
                midcar = true;
            }
        }
    }

    void spawnYellow()
    {
        int spawn = Random.Range(0, 2);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(MoveYellowCarPrefab, myPosition, MoveYellowCarPrefab.transform.rotation);
            }
        }
        if (spawn == 1)
        {

            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(MidYellowCarPrefab, myPosition, MidYellowCarPrefab.transform.rotation);
                midcar = true;
            }
        }
    }

    void spawnRedBack()
    {
        int spawn = Random.Range(0, 2);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = midBack;
                GameObject car = Instantiate(MoveRedCarPrefab, myPosition, MoveRedCarPrefab.transform.rotation);
            }
        }
        if (spawn == 1)
        {
            {
                Vector3 myPosition = midBack;
                GameObject car = Instantiate(MidRedCarPrefab, myPosition, MidRedCarPrefab.transform.rotation);
                midcar = true;
            }
        }
    }

    void spawnYellowBack()
    {
        int spawn = Random.Range(0, 2);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = midBack;
                GameObject car = Instantiate(MoveYellowCarPrefab, myPosition, MoveYellowCarPrefab.transform.rotation);
            }
        }
        if (spawn == 1)
        {

            {
                Vector3 myPosition = midBack;
                GameObject car = Instantiate(MidYellowCarPrefab, myPosition, MidYellowCarPrefab.transform.rotation);
                midcar = true;
            }
        }
    }

    void tripleCoinLeft()
    {
        spawnBronze = Random.Range(0, 10);
        if (spawnBronze > 6)
        {
            GameObject b1 = Instantiate(BronzeCoinPrefab, new Vector3(-2, 0.7f, 105), BlueCarPrefab.transform.rotation);
            GameObject b2 = Instantiate(BronzeCoinPrefab, new Vector3(-2, 0.7f, 108), BlueCarPrefab.transform.rotation);
            GameObject b3 = Instantiate(BronzeCoinPrefab, new Vector3(-2, 0.7f, 111), BlueCarPrefab.transform.rotation);
        }
    }
    void tripleCoinMid()
    {
        spawnBronze = Random.Range(0, 10);
        if (spawnBronze > 6)
        {
            GameObject b1 = Instantiate(BronzeCoinPrefab, new Vector3(0, 0.7f, 105), BlueCarPrefab.transform.rotation);
            GameObject b2 = Instantiate(BronzeCoinPrefab, new Vector3(0, 0.7f, 108), BlueCarPrefab.transform.rotation);
            GameObject b3 = Instantiate(BronzeCoinPrefab, new Vector3(0, 0.7f, 111), BlueCarPrefab.transform.rotation);
        }
    }
    void tripleCoinRight()
    {
        spawnBronze = Random.Range(0, 10);
        if (spawnBronze > 6)
        {
            GameObject b1 = Instantiate(BronzeCoinPrefab, new Vector3(2, 0.7f, 105), BlueCarPrefab.transform.rotation);
            GameObject b2 = Instantiate(BronzeCoinPrefab, new Vector3(2, 0.7f, 108), BlueCarPrefab.transform.rotation);
            GameObject b3 = Instantiate(BronzeCoinPrefab, new Vector3(2, 0.7f, 111), BlueCarPrefab.transform.rotation);
        }
    }
    void tripleCoinLeftBack()
    {
        spawnBronze = Random.Range(0, 10);
        if (spawnBronze > 6)
        {
            GameObject b1 = Instantiate(BronzeCoinPrefab, new Vector3(-2, 0.7f, 108), BlueCarPrefab.transform.rotation);
            GameObject b2 = Instantiate(BronzeCoinPrefab, new Vector3(-2, 0.7f, 111), BlueCarPrefab.transform.rotation);
            GameObject b3 = Instantiate(BronzeCoinPrefab, new Vector3(-2, 0.7f, 114), BlueCarPrefab.transform.rotation);
        }
    }
    void tripleCoinMidBack()
    {
        spawnBronze = Random.Range(0, 10);
        if (spawnBronze > 6)
        {
            GameObject b1 = Instantiate(BronzeCoinPrefab, new Vector3(0, 0.7f, 108), BlueCarPrefab.transform.rotation);
            GameObject b2 = Instantiate(BronzeCoinPrefab, new Vector3(0, 0.7f, 111), BlueCarPrefab.transform.rotation);
            GameObject b3 = Instantiate(BronzeCoinPrefab, new Vector3(0, 0.7f, 114), BlueCarPrefab.transform.rotation);
        }
    }
    void tripleCoinRightBack()
    {
        spawnBronze = Random.Range(0, 10);
        if (spawnBronze > 6)
        {
            GameObject b1 = Instantiate(BronzeCoinPrefab, new Vector3(2, 0.7f, 108), BlueCarPrefab.transform.rotation);
            GameObject b2 = Instantiate(BronzeCoinPrefab, new Vector3(2, 0.7f, 111), BlueCarPrefab.transform.rotation);
            GameObject b3 = Instantiate(BronzeCoinPrefab, new Vector3(2, 0.7f, 114), BlueCarPrefab.transform.rotation);
        }
    }

    void spawnRandomBlue()
    {
        int spawn = Random.Range(0, 3);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = left;
                GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            }
            tripleCoinLeft();
        }
        if (spawn == 1)
        {

            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            }
            tripleCoinMid();
        }
        if (spawn == 2)
        {

            {
                Vector3 myPosition = right;
                GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            }
            tripleCoinRight();
        }
    }
    void spawnRandomBlueBack()
    {
        int spawn = Random.Range(0, 2);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = new Vector3(2, 0.045f, 110);
                GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            }
            tripleCoinLeft();
        }
        if (spawn == 1)
        {
            {
                Vector3 myPosition = new Vector3(-2, 0.045f, 110);
                GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            }
            tripleCoinRight();
        }
    }

    void spawnPurple()
    {
        int spawn = Random.Range(0, 2);
        if (spawn == 0)
        {
            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(PurpleCarPrefab, myPosition, PurpleCarPrefab.transform.rotation);
            }
        }
        if (spawn == 1)
        {

            {
                Vector3 myPosition = mid;
                GameObject car = Instantiate(PurpleCarPrefab2, myPosition, PurpleCarPrefab2.transform.rotation);
            }
        }
    }

    void spawnCoin()
    {
        int spawn = Random.Range(0, 10);
        if (spawn > 7)
        {
            coin = true;
        }
    }

    void doSpawnCars()
    {
        timer = Random.Range(0.5f, scoreKeeper.carTimerHigh);
        carPos = Random.Range(scoreKeeper.carSpawnLow, scoreKeeper.carSpawnHigh + 1);
        //scoreKeeper.carSpawnLow, scoreKeeper.carSpawnHigh + 1

        //-----------------LEVEL 1

        //sininen keskellä
        if (carPos == 0 ^ carPos == 1 ^ carPos == 2)
        {
            spawnRandomBlue();
        }

        //-------------------------------- LEVEL 2

        //2 sinistä vasemmalla
        if (carPos == 3)
        {
            Vector3 myPosition = left;
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = mid;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            spawnBronze = Random.Range(0, 10);
            if (spawnBronze > 6)
            {
                GameObject b1 = Instantiate(BronzeCoinPrefab, right, BlueCarPrefab.transform.rotation);
            }

        }
        //2 sinistä oikealla
        if (carPos == 4)
        {
            Vector3 myPosition = right;
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = mid;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            if (spawnBronze > 6)
            {
                GameObject b1 = Instantiate(BronzeCoinPrefab, left, BlueCarPrefab.transform.rotation);
            }
        }

        //-------------------------------- LEVEL 3

        //2 sinistä reunat
        if (carPos == 5)
        {
            Vector3 myPosition = right;
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = left;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            spawnBronze = Random.Range(0, 10);
            if (spawnBronze > 6)
            {
                GameObject b1 = Instantiate(BronzeCoinPrefab, mid, BlueCarPrefab.transform.rotation);
            }
        }
        //2 sinistä aura vasen
        if (carPos == 6)
        {
            Vector3 myPosition = mid;
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = leftBack;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = left;
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
                Vector3 beepPosition = new Vector3(0, 1f, 101);
                GameObject beep = Instantiate(Beep, beepPosition, Quaternion.identity);
            }
            coin = false;
        }
        //2 sinistä aura oikea
        if (carPos == 7)
        {
            Vector3 myPosition = mid;
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = rightBack;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = right;
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
                Vector3 beepPosition = new Vector3(0, 1f, 101);
                GameObject beep = Instantiate(Beep, beepPosition, Quaternion.identity);
            }
            coin = false;
        }

        //------------------------- LEVEL 4

        //punainen
        if (carPos == 8)
        {
            spawnRed();
            if (spawnBronze > 6)
            {
                GameObject b1 = Instantiate(BronzeCoinPrefab, left, BlueCarPrefab.transform.rotation);
            }
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = left;
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
        //keltainen
        if (carPos == 9)
        {
            spawnYellow();
            if (spawnBronze > 6)
            {
                GameObject b1 = Instantiate(BronzeCoinPrefab, right, BlueCarPrefab.transform.rotation);
            }
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = right;
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }

        //---------------------------    LEVEL 5

        // aura sinikelt
        if (carPos == 10)
        {
            spawnYellow();
            Vector3 myPosition2 = new Vector3(2, 0.045f, 110);
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            if (midcar == true)
            {
                tripleCoinLeftBack();
            }
            else
            {
                tripleCoinMidBack();
            }
            midcar = false;
        }
        // aura sinipun
        if (carPos == 11)
        {
            spawnRed();
            Vector3 myPosition2 = new Vector3(-2, 0.045f, 110);
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            if (midcar == true)
            {
                tripleCoinRightBack();
            }
            else
            {
                tripleCoinMidBack();
            }
            midcar = false;
        }

        //---------------------------   LEVEL 6
        // jono sinikelt
        if (carPos == 12)
        {
            spawnYellow();
            Vector3 myPosition2 = new Vector3(0, 0.045f, 110);
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            tripleCoinRight();
        }
        // jono sinipun
        if (carPos == 13)
        {
            spawnRed();
            Vector3 myPosition2 = new Vector3(0, 0.045f, 110);
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            tripleCoinLeft();
        }
        // liila auto
        if (carPos == 14)
        {
            spawnPurple();
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = new Vector3(0, 0.045f, 111);
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }

        //---------------------------   LEVEL 7
        // vierekkäin sinikelt
        if (carPos == 15)
        {
            spawnYellow();
            Vector3 myPosition2 = right;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            if (midcar == true)
            {
                tripleCoinLeft();
            }
            else
            {
                tripleCoinMid();
            }
            midcar = false;
        }
        //vierekkäin sinipuna
        if (carPos == 16)
        {
            spawnRed();
            Vector3 myPosition2 = left;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            if (midcar == true)
            {
                tripleCoinRight();
            }
            else
            {
                tripleCoinMid();
            }
            midcar = false;
        }

        //---------------------------- LEVEL 8
        //siniliila
        if (carPos == 17)
        {
            spawnRandomBlueBack();
            spawnPurple();
        }

        //----------------------------- LEVEL 9
        //punaliila
        if (carPos == 18)
        {
            spawnRedBack();
            spawnPurple();
        }
        //keltaliila
        if (carPos == 19)
        {
            spawnYellowBack();
            spawnPurple();
        }

        //------------------------------ LEVEL 10
        //helvettiaura 
        if (carPos == 20)
        {
            Vector3 myPosition = mid;
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = new Vector3(-2, 0.045f, 107);
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            Vector3 myPosition3 = new Vector3(2, 0.045f, 107);
            GameObject car3 = Instantiate(BlueCarPrefab, myPosition3, BlueCarPrefab.transform.rotation);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = midBack;
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
        //helvettiaura reverse
        if (carPos == 21)
        {
            Vector3 myPosition = new Vector3(0, 0.045f, 107);
            GameObject car = Instantiate(BlueCarPrefab, myPosition, BlueCarPrefab.transform.rotation);
            Vector3 myPosition2 = left;
            GameObject car2 = Instantiate(BlueCarPrefab, myPosition2, BlueCarPrefab.transform.rotation);
            Vector3 myPosition3 = right;
            GameObject car3 = Instantiate(BlueCarPrefab, myPosition3, BlueCarPrefab.transform.rotation);
            spawnCoin();
            if (coin == true)
            {
                Vector3 coinPosition = mid;
                GameObject coin = Instantiate(GoldCoinPrefab, coinPosition, Quaternion.identity);
            }
            coin = false;
        }
    }

}
