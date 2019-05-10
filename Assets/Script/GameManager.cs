using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    [SerializeField] private GameObject enemy;

    [SerializeField] private GameObject enemy2;

    [SerializeField]private Transform spawnPoint;

    [SerializeField]private Transform spawnPoint2;

    [SerializeField] private Text moneyText,scoreText;

    [SerializeField] private GameObject loseScreen;
    [Header("Unity Stuff")]
    public Image playerHealth;

   // [SerializeField] private Slider healthSlider;

    public GameObject selectedWizard;

    public int money,score;
    //int counter = 0;
    public float health;
    public float maxHealth;
    private float spawnCooldown;
    private float spawnCooldown2;

	// Use this for initialization
	void Start () {
        score = 0;
        health = maxHealth;
        spawnCooldown = 2f;
        //loseScreen = GameObject.FindGameObjectWithTag("OverScreen");
        // healthSlider.maxValue = maxhealth;
        // healthSlider.value = health;
        spawnCooldown2 = 2.5f;
	}
	
	// Update is called once per frame
	public void Update () {
        playerHealth.fillAmount = health / maxHealth;
        moneyText.text = ": " + money.ToString();
        scoreText.text = "Score : " + score.ToString();
        spawnCooldown -= Time.deltaTime;
        spawnCooldown2 -= Time.deltaTime;
        
        if(spawnCooldown <= 0)
        {
            Instantiate(enemy,spawnPoint.position,Quaternion.identity);
            enemy.GetComponent<Enemy>().startHealth=(Random.Range(10,30));
            spawnCooldown = 2f;
            //counter++;
        }
        if(spawnCooldown2 <= 0)
        {
            Instantiate(enemy2,spawnPoint2.position,Quaternion.identity);
            enemy2.GetComponent<Enemy>().startHealth=(Random.Range(20,40));
            spawnCooldown2 = 2.5f;
        }
        //if (counter >= 3)
        //    spawnCooldown = 15f;
        CheckLose();
	}

    private void CheckLose()
    {
        if(health <= 0)
        {
           
            if(PlayerPrefs.GetInt("HighScore",0) <= score)
            PlayerPrefs.SetInt("HighScore", score);
            loseScreen.SetActive(true); 
        }
    }
}
