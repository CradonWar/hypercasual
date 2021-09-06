using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    int health;
    GameObject healthBar;
    [SerializeField] GameObject health1;
    [SerializeField] GameObject health2;
    [SerializeField] GameObject health3;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.Find("Health Bar");
        health = healthBar.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyHearts();
    }

    public void DestroyHearts()

    {
        health = FindObjectOfType<Player>().GetHealth();
        if (health <= 2000)
        {
            Destroy(health3);
        }

        if (health <= 1000)
        {
            Destroy(health2);
        }

        if (health <= 0)
        {
            Destroy(health1);
            Destroy(healthBar);
        }
    }
}
