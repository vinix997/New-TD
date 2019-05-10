using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    [SerializeField] private GameObject enemy;

    [SerializeField]private Vector3 spawnPoint;

    [SerializeField] private Text moneyText,scoreText;

    [Header("Unity Stuff")]
    public Image playerHealth;

   // [SerializeField] private Slider healthSlider;

    public GameObject selectedWizard;

    public int money,score;
    //int counter = 0;
    public float health;
    public float maxHealth;
    private float spawnCooldown;

	// Use this for initialization
	void Start () {
        score = 0;
        health = maxHealth;
        spawnCooldown = 2f;
        // healthSlider.maxValue = maxhealth;
        // healthSlider.value = health;
	}
	
	// Update is called once per frame
	void Update () {
       // healthSlider.value = health;
       
        playerHealth.fillAmount = health / maxHealth;
        moneyText.text = ": " + money.ToString();
        scoreText.text = "Score : " + score.ToString();
        spawnCooldown -= Time.deltaTime;
        if(spawnCooldown <= 0)
        {
            Instantiate(enemy,spawnPoint,Quaternion.identity);
            spawnCooldown = 2f;
            //counter++;
        }
        //if (counter >= 3)
        //    spawnCooldown = 15f;
        CheckLose();
	}

    private void CheckLose()
    {
        if(health <= 0)
        {
            Time.timeScale = 0;
            if(PlayerPrefs.GetInt("HighScore",0) <= score)
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
