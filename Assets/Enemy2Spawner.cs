using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Spawner : MonoBehaviour {

	private float spawnCooldown2;

	[SerializeField] private GameObject enemy2;

	[SerializeField]private Transform spawnPoint2;

	public float rangeHard = 20f;
	// Use this for initialization
	void Start () {
		spawnCooldown2 = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		spawnCooldown2 -= Time.deltaTime;
		rangeHard += Time.deltaTime * (0.5f);
		  if(spawnCooldown2 <= 0)
        {
            Instantiate(enemy2,spawnPoint2.position,Quaternion.identity);
            enemy2.GetComponent<Enemy>().startHealth=(Random.Range(rangeHard,rangeHard+20));
            spawnCooldown2 = 2.5f;
        }
	}
}
