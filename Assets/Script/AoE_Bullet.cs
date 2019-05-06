using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoE_Bullet : MonoBehaviour {

    public Transform enemy;
    private Vector2 target;
    //private float speed;
    private float timer;
    [SerializeField]
    private int vanishTime;
    
    public float damage;
    // Use this for initialization
    void Start()
    {
        timer = 0;
        //enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        //target = new Vector2(enemy.position.x, enemy.position.y);
        //speed = 10f;
        //transform.position = target;
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn di lokasi target 
        //transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //Utk timer bullet menghilang jika lebih dari 6 detik
        timer += Time.deltaTime;
        if (timer >= vanishTime)
        {
            Destroy(gameObject);
        }


    }
}
