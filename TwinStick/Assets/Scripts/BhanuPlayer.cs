using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BhanuPlayer : MonoBehaviour 
{

	void Start() 
    {
		
	}

	void Update() 
    {
		if(Time.timeScale == 0)
            return;

        Debug.Log("H : " + CrossPlatformInputManager.GetAxis("Horizontal"));
        Debug.Log("V : " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
}
