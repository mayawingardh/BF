using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointSystem : MonoBehaviour
{
    int TotalPoints;

    public int HatPoints;
    public int TopPoints;
    public int BottomPoints;

    void Start()
    {
        HatPoints = 0;
        TopPoints = 0;
        BottomPoints = 0;
    }

    public void CalculateTotalPoints()
    {
        TotalPoints = HatPoints + TopPoints + BottomPoints;

        if(TotalPoints >= 2)
        {
            SceneManager.LoadScene(1);
        }

        if(TotalPoints <= 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
