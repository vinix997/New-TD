using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBullet : MonoBehaviour {

    public Transform enemy;
    private Vector2 target;
    private float speed;
    private float timer=0;
    // Use this for initialization
    void Start()
    {
            //enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
            target = new Vector2(enemy.position.x, enemy.position.y);
            //speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn di lokasi target 
        transform.position = target;
        //Utk timer bullet menghilang jika lebih dari 6 detik
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Destroy(gameObject);
            timer = 0;
        }
   

    }
   
}
