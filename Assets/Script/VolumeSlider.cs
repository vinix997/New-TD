using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeSlider : MonoBehaviour {
	public AudioMixer mainMenu;
	public AudioMixer ingame;
    public float save;
    public Slider vol;
    public void Start()
    {
       save = PlayerPrefs.GetFloat("saved");
       vol.value = save;
    }
	public void SetVolume(float volume)
    {
        mainMenu.SetFloat("volume", volume);
        save = volume;
        PlayerPrefs.SetFloat("saved",save);
        PlayerPrefs.Save();
        
    }
  
    

}
