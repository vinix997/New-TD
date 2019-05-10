using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingButton : MonoBehaviour {

    [SerializeField] private GameObject wizardSelected;

    [SerializeField]
    private Sprite pressed,idle;

    private void Update()
    {
        if(FindObjectOfType<GameManager>().selectedWizard == wizardSelected)
        {
            GetComponent<SpriteRenderer>().sprite = pressed;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = idle;
        }
    }

    public void ChooseWizard()
    {
        GameManager.FindObjectOfType<GameManager>().selectedWizard = wizardSelected;
    }
}
