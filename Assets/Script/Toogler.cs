using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toogler : MonoBehaviour {
	public Toggle onSwitch;
	public void Start()
	{
		LoadSetting();		
	}
	public void Switching()
	{
		if(onSwitch.isOn)
		{
			Debug.Log("switch is on");
				AudioListener.pause = false;
			PlayerPrefs.SetInt("switch",1);
		}
		else
		{
			AudioListener.pause = true;
			PlayerPrefs.SetInt("switch",0);
		}
	}
	// public void SaveSetting()
	// {
	// 	PlayerPrefs.SetInt("switch",onSwitch ? 1 : 0);
	// 	PlayerPrefs.Save();
	// }
	public void LoadSetting()
	{
		if(PlayerPrefs.GetInt("switch")==1)
		{
			onSwitch.isOn=true;
		}		
		else{
			onSwitch.isOn=false;
		}
	}
}
