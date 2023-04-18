using System.Collections.Generic;
using UnityEngine;

public class HighScores : MonoBehaviour
{
    public HighScoreDisplay[] highScoreDisplayArray;
    List<HighScoreEntry> scores = new List<HighScoreEntry>();

    void Start()
    {
        // Adds some test data
        AddNewScore("Joh", 4500);
        AddNewScore("Max", 5520);
        AddNewScore("Dav", 380);
        AddNewScore("Stv", 6654);
        AddNewScore("Mik", 11021);

        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        scores.Sort((HighScoreEntry x, HighScoreEntry y) => y.score.CompareTo(x.score));

        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(scores[i].name, scores[i].score);
            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
            }
        }
    }

    void AddNewScore(string entryName, int entryScore)
    {
        scores.Add(new HighScoreEntry { name = entryName, score = entryScore });
    }
}