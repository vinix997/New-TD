using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour {

    public float towerDamage;
    public float attackCooldown;
    private float level;
    [SerializeField] private int price;

    private void Start()
    {
        level = 1;
    }

    private void Update()
    {
        if(level >=5 )
        {
            Destroy(gameObject);
        }
    }

    public void Up()
    {
        if (FindObjectOfType<GameManager>().money >= price)
        {
            towerDamage += 1;
            attackCooldown -= 0.5f;
            level++;
            FindObjectOfType<GameManager>().money -= price;
            price += 10;
        }

    }
}
