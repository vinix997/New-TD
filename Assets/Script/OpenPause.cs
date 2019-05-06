using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPause : MonoBehaviour {
    public GameObject pause;

    public void setActive()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
    }
    public void setDeactive()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
