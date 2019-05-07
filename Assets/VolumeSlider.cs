using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class VolumeSlider : MonoBehaviour {
	public AudioMixer mainMenu;
	public AudioMixer ingame;
    public float save;
   
	public void SetVolume(float volume)
    {
        mainMenu.SetFloat("volume", volume);
    }

}
