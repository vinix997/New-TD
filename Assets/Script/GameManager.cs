using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    [SerializeField] private GameObject enemy;

    [SerializeField]private Vector3 spawnPoint;

    [SerializeField] private Text moneyText;

    [SerializeField] private Slider healthSlider;

    public GameObject selectedWizard;

    public int money,Maxhealth;
    //int counter = 0;
    public int health;
    private float spawnCooldown;

	// Use this for initialization
	void Start () {
        health = Maxhealth;
        spawnCooldown = 2f;
        healthSlider.maxValue = Maxhealth;
        healthSlider.value = health;
	}
	
	// Update is called once per frame
	void Update () {
        healthSlider.value = health;
        moneyText.text = "Money : " + money.ToString();
        spawnCooldown -= Time.deltaTime;
        if(spawnCooldown <= 0)
        {
            Instantiate(enemy,spawnPoint,Quaternion.identity);
            spawnCooldown = 2f;
            //counter++;
        }
        //if (counter >= 3)
        //    spawnCooldown = 15f;
	}
}
