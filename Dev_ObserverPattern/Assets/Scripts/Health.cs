using System;
using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float fullHealth = 100f;
    [SerializeField] float drainPerSecond = 2f;
    float currentHealth = 0;

    int lastLevel;

    private void Awake()
    {
        ResetHealth();
        StartCoroutine(HealthDrain());
    }

    private void Start()
    {
        lastLevel = GetComponent<Level>().GetLevel();
    }

    private void Update()
    {
        int currentLevel=GetComponent<Level>().GetLevel();

        if (lastLevel < currentLevel)
        {
            lastLevel = currentLevel;
            ResetHealth();
        }
    }

    public float GetHealth()
    {
        return currentHealth;
    }

    public float GetFullHealth()
    {
        return fullHealth;
    }

    public void ResetHealth()
    {
        currentHealth = fullHealth;
        
    }

    private IEnumerator HealthDrain()
    {
        while (currentHealth > 0)
        {
            currentHealth -= drainPerSecond;
            
            yield return new WaitForSeconds(1);
        }
    }

}