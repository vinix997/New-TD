using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    [SerializeField] private GameObject enemy;

    [SerializeField]private Transform spawnPoint;

    [SerializeField] private Text moneyText,scoreText;

    [SerializeField] private GameObject loseScreen;

  

    [Header("Unity Stuff")]
    public Image playerHealth;

    public GameObject selectedWizard;

    public int money,score;

    public float health;

    public float maxHealth;
    
    private float spawnCooldown;
    
    public float range = 10f;
    

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
        score = 0;
        health = maxHealth;
        spawnCooldown = 2f;
        

        
	}
	
	// Update is called once per frame
	public void Update () {
        playerHealth.fillAmount = health / maxHealth;
        moneyText.text = ": " + money.ToString();
        scoreText.text = "Score : " + score.ToString();
        spawnCooldown -= Time.deltaTime;
        
        range += Time.deltaTime * (0.5f);
        
        
        if(spawnCooldown <= 0)
        {
            Instantiate(enemy,spawnPoint.position,Quaternion.identity);
            enemy.GetComponent<Enemy>().startHealth=(Random.Range(range,range+20));
            spawnCooldown = 2f;
       
        }
     
        CheckLose();
	}

    private void CheckLose()
    {
        if(health <= 0)
        {
            GameObject level = GameObject.Find("LevelDecider");
            LevelDecider levelDecider = level.GetComponent<LevelDecider>();
            Time.timeScale=0;
            loseScreen.SetActive(true); 
            if(levelDecider.levels == 1)
            {
            if(PlayerPrefs.GetInt("Stage1 score",0) <= score)
            PlayerPrefs.SetInt("Stage1 score", score);
            
            }
            else if(levelDecider.levels == 2)
            {
            if(PlayerPrefs.GetInt("Stage2 score",0) <= score)
            PlayerPrefs.SetInt("Stage2 score", score);
            
            }
            else if(levelDecider.levels == 3)
            {
            if(PlayerPrefs.GetInt("Stage3 score",0) <= score)
            PlayerPrefs.SetInt("Stage3 score", score);
            
            }
        }
    }
}
