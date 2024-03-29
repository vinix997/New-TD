﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AoE_Tower : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject towerName;

    [SerializeField]
    private GameObject nameButton, upgradeButton,demolishButton;

    [SerializeField]
    private GameObject enemy;

    //[SerializeField]
    //private AudioClip atk;

    public GameObject land;

    public int price;

    public float damage;

    public float cooldownTime;
    private float attackCooldown;
    private float timer;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (enemy == null && collision.tag == "Enemy")
        {
            enemy = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(enemy == collision.gameObject)
        {
            enemy = null;
        }
    }

    private void Start()
    {
        enemy = null;
        attackCooldown = 3f;
        demolishButton.GetComponent<DemolishTower>().tower = gameObject;
        demolishButton.GetComponent<DemolishTower>().land = land;
        nameButton.GetComponent<NameToggler>().demolishButton = Instantiate(demolishButton, transform.position + new Vector3(-4, -4), Quaternion.identity, transform);
        nameButton.GetComponent<NameToggler>().towerName = Instantiate(towerName, transform.position + new Vector3(0, 5), Quaternion.identity, transform);
        upgradeButton.GetComponent<UpgradeButton>().tower = gameObject;
        nameButton.GetComponent<NameToggler>().upgradeButton = Instantiate(upgradeButton, transform.position+new Vector3(4,-4), Quaternion.identity, transform);
        Instantiate(nameButton, transform.position, Quaternion.identity, transform).GetComponent<NameToggler>();
        
    }

    private void Update()
    {
        attackCooldown -= Time.deltaTime;
        if (enemy != null && attackCooldown <= 0)
        {
            GetComponent<Animator>().SetTrigger("Attack");
            bullet.GetComponent<AoE_BulletPrep>().enemy = enemy.transform;
            bullet.GetComponent<AoE_BulletPrep>().damage = damage;
            timer += Time.deltaTime;

            Instantiate(bullet, transform.position, Quaternion.identity);
            attackCooldown = cooldownTime;
        }
    }
}
