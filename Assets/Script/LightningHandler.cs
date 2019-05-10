using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningHandler : MonoBehaviour {

    public float cooldown;
	// Use this for initialization
	void Start () {
        GetComponentInParent<Enemy>().lightning = gameObject;
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;
        Dead();
	}

    private void Dead()
    {
        if(cooldown < 0)
        gameObject.SetActive(false);
    }
}
