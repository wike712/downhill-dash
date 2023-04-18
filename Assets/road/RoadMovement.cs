using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public GameObject[] RoadPieces = new GameObject[2];
    const float RoadLength = 192; //length of roads
    const float RoadSpeed = 7f; //speed to scroll roads at
    void Update()
    {
        if (
        FindObjectOfType<GameManager>().gameOver == false)
        {
            foreach (GameObject road in RoadPieces)
            {
                Vector3 newRoadPos = road.transform.position;
                newRoadPos.z -= RoadSpeed * Time.deltaTime;
                if (newRoadPos.z < -RoadLength / 2)
                {
                    newRoadPos.z += RoadLength;
                }
                road.transform.position = newRoadPos;
            }
        }
    }
}