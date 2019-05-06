using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject enemy;
    public float damage;

    [SerializeField]
    private float speed;

	
	
	// Update is called once per frame
	void Update () {
        if (enemy != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemy.transform.position,speed*Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
}
