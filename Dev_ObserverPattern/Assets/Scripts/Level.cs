using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int pointsPerLevel = 200;
    
    int experiencePoints = 0;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(10);
        }
    }

    public void GainExperience(int points)
    {
        //int level = GetLevel();
        experiencePoints += points;

        //if (GetLevel() > level)
        //{
        //    GetComponent<Health>().ResetHealth();
        //}

    }

    public int GetExperience()
    {
        return experiencePoints;
    }

    public int GetLevel()
    {
        return experiencePoints / pointsPerLevel;
    }

}