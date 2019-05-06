using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameToggler : MonoBehaviour {

    public bool clicked;

    public GameObject towerName, upgradeButton, demolishButton;

    // Use this for initialization
    void Start () {
        clicked = true;
        upgradeButton.SetActive(false);
        demolishButton.SetActive(false);
        towerName.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void NameToggle()
    {
        if (!clicked)
        {
            clicked = true;
            if (upgradeButton != null || demolishButton != null)
            {
                upgradeButton.SetActive(false);
                demolishButton.SetActive(false);
            }
            towerName.SetActive(false);
        }
        else if (clicked)
        {
            clicked = false;
            if (upgradeButton != null || demolishButton != null)
            {
                upgradeButton.SetActive(true);
                demolishButton.SetActive(true);
            }
            towerName.SetActive(true);
        }
    }
}
