using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreShow : MonoBehaviour {

    [SerializeField] private Text score;
    [SerializeField] private Text score2;
    [SerializeField] private Text score3;
    // Use this for initialization
    void Start () {
        // score = GetComponent<Text>();
        // score2 = GetComponent<Text>();
        // score3 = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = PlayerPrefs.GetInt("Stage1 score", 0).ToString();
        score2.text = PlayerPrefs.GetInt("Stage2 score", 0).ToString();
        score3.text = PlayerPrefs.GetInt("Stage3 score", 0).ToString();
	}
}
