using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour {
    public static AudioClip fire, ice, electric;
    static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
        fire = Resources.Load<AudioClip>("fire");
        ice = Resources.Load<AudioClip>("ice");
        electric = Resources.Load<AudioClip>("electric");
        audioSrc = GetComponent<AudioSource>();
	}
    


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSrc.PlayOneShot(fire);
                break;
            case "ice":
                audioSrc.PlayOneShot(ice);
                break;
            case "electric":
                audioSrc.PlayOneShot(electric);
                break;
        }
    }

}
