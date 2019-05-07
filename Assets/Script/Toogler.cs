using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toogler : MonoBehaviour {

	public void Switching()
	{
		bool onSwitch = gameObject.GetComponent<Toggle>().isOn;
		if(onSwitch)
		{
			Debug.Log("switch is on");
				AudioListener.pause = false;
		}
		else
		{
			AudioListener.pause = true;
		}
	}
}
