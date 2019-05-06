using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    //[SerializeField]
    //private GameObject towerName;
    public bool isEmpty;

    private void Start()
    {
        isEmpty = true;
    }
   
   
    public void CreateTower()
    {
        if(isEmpty && GameManager.FindObjectOfType<GameManager>().selectedWizard != null)
        {
            if (FindObjectOfType<GameManager>().selectedWizard.GetComponent<WizardTower>() != null)
            {
                if (FindObjectOfType<GameManager>().selectedWizard.GetComponent<WizardTower>().price <= FindObjectOfType<GameManager>().money)
                    FindObjectOfType<GameManager>().money -= FindObjectOfType<GameManager>().selectedWizard.GetComponent<WizardTower>().price;
                else
                    return;
                FindObjectOfType<GameManager>().selectedWizard.GetComponent<WizardTower>().land = gameObject;
                Instantiate(GameManager.FindObjectOfType<GameManager>().selectedWizard, transform.position, Quaternion.identity, transform);
                isEmpty = false;
                GameManager.FindObjectOfType<GameManager>().selectedWizard = null;
            }
            else
            {
                if (FindObjectOfType<GameManager>().selectedWizard.GetComponent<AoE_Tower>().price <= FindObjectOfType<GameManager>().money)
                    FindObjectOfType<GameManager>().money -= FindObjectOfType<GameManager>().selectedWizard.GetComponent<AoE_Tower>().price;
                else
                    return;
                FindObjectOfType<GameManager>().selectedWizard.GetComponent<AoE_Tower>().land = gameObject;
                Instantiate(GameManager.FindObjectOfType<GameManager>().selectedWizard, transform.position, Quaternion.identity, transform);
                isEmpty = false;
                GameManager.FindObjectOfType<GameManager>().selectedWizard = null;
            }
        }

    }
   
    
}
