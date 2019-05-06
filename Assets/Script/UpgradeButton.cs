using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour {

    public GameObject tower;
    private int counter;
    [SerializeField] private int price;

    private void Start()
    {
        counter = 0;
    }

    public void Upgrade()
    {
        if (FindObjectOfType<GameManager>().money >= price)
        {
            if (tower.GetComponent<AoE_Tower>() != null)
            {
                tower.GetComponent<AoE_Tower>().damage += 2;
            }
            else
            {
                tower.GetComponent<WizardTower>().damage += 2;
            }
            FindObjectOfType<GameManager>().money -= price;
            price += 15;
            counter++;
        }
        if(counter >= 5)
        {
            Destroy(gameObject);
        }
    }
}
