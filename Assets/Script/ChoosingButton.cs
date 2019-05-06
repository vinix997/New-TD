using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingButton : MonoBehaviour {

    [SerializeField] private GameObject wizardSelected;

	public void ChooseWizard()
    {
        GameManager.FindObjectOfType<GameManager>().selectedWizard = wizardSelected;
    }
}
