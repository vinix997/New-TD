using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    [SerializeField] private GameObject enemy;

    [SerializeField]private Vector3 spawnPoint;

    [SerializeField] private Text moneyText;

    public GameObject selectedWizard;

    public int money;
    //int counter = 0;
    private float spawnCooldown;

	// Use this for initialization
	void Start () {
        spawnCooldown = 2f;
	}
	
	// Update is called once per frame
	void Update () {
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
