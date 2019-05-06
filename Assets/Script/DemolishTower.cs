using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemolishTower : MonoBehaviour {

    public GameObject tower;
    public GameObject land;

    // Update is called once per frame
    public void Demolish() {
        land.GetComponent<Land>().isEmpty = true;
        Destroy(tower);
    }

}
