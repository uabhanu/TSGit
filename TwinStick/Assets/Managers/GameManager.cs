using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour 
{
    bool m_gamePaused = false;
    float m_defaultTimeScale , m_fixedDeltaTime;

    [HideInInspector] public bool m_isRecording = true;

	void Start() 
    {
        m_defaultTimeScale = Time.timeScale;
        m_fixedDeltaTime = Time.fixedDeltaTime;
//        BhanuPrefsManager.DeleteAll(); //This is for Testing purposes only and remove this for Live version
//		BhanuPrefsManager.UnlockLevel(2);
//        Debug.Log(BhanuPrefsManager.IsLevelUnlocked(2));
//        Debug.Log(BhanuPrefsManager.IsLevelUnlocked(1));
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

        if(Input.GetKeyDown(KeyCode.P))
        {
            if(!m_gamePaused)
            {
                m_gamePaused = true;
                Pause();   
            }

            else if(m_gamePaused)
            {
                m_gamePaused = false;
                Resume();   
            }
        }

        Debug.Log("Update Method"); //This should work fine if you use UI buttons instead
	}

    void Pause()
    {
        Time.fixedDeltaTime = 0;
        Time.timeScale = 0;
    }

    void Resume()
    {
        Time.fixedDeltaTime = m_fixedDeltaTime;
        Time.timeScale = m_defaultTimeScale;
    }
}
