using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour 
{
    GameObject m_bhanuPlayer;

	void Start() 
    {
		m_bhanuPlayer = GameObject.FindGameObjectWithTag("Player");
	}

	void LateUpdate() 
    {
		if(Time.timeScale == 0)
            return;

            transform.LookAt(m_bhanuPlayer.transform);
	}
}
