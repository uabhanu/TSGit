using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BhanuReplay : MonoBehaviour 
{

	void Start() 
    {
		
	}

	void Update() 
    {
		
	}
}

public class BhanuKeyframe
{
    float m_frameTime;
    Quaternion m_rotation;
    Vector3 m_position;

    public BhanuKeyframe(float time , Quaternion rot , Vector3 pos)
    {
        m_frameTime = time;
        m_rotation = rot;
        m_position = pos;
    }
}
