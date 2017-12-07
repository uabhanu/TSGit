using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfieStick : MonoBehaviour 
{
    float m_panSpeed = 1.95f;
    GameObject m_bhanuPlayer;
    Vector3 m_armRotation;

	void Start() 
    {
        m_armRotation = transform.rotation.eulerAngles;
        m_bhanuPlayer = GameObject.FindGameObjectWithTag("Player");	
	}

	void Update() 
    {
		if(Time.timeScale == 0)
            return;

        m_armRotation.x += Input.GetAxis("RVertical") * m_panSpeed;
        m_armRotation.y += Input.GetAxis("RHorizontal") * m_panSpeed;
        transform.position = m_bhanuPlayer.transform.position;
        transform.rotation = Quaternion.Euler(m_armRotation);
	}
}
