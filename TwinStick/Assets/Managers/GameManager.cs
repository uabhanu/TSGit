using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour 
{
    [HideInInspector] public bool m_isRecording = true;

	void Start() 
    {
        BhanuPrefsManager.DeleteAll(); //This is for Testing purposes only and remove this for Live version
		BhanuPrefsManager.UnlockLevel(2);
        Debug.Log(BhanuPrefsManager.IsLevelUnlocked(2));
        Debug.Log(BhanuPrefsManager.IsLevelUnlocked(1));
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
