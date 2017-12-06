using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour 
{
    [HideInInspector] public bool m_isRecording = true;

	void Start() 
    {
		BhanuPrefsManager.UnlockLevel(2);
        Debug.Log(BhanuPrefsManager.IsLevelUnlocked(1)); //This should return false according to tutorial but returning true
        Debug.Log(BhanuPrefsManager.IsLevelUnlocked(2));
	}

	void Update() 
    {
		if(Time.timeScale == 0)
            return;

        if(CrossPlatformInputManager.GetButton("Fire1")) //Press & hold 'r' key for PC or Mac
        {
            m_isRecording = false;
        }
        else //Use if(CrossPlatformInputManager.GetButtonUp("Fire1")) if any weird issues
        {
            m_isRecording = true;
        }
	}
}
