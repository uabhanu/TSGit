using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BhanuReplay : MonoBehaviour 
{
    const int m_bufferFrames = 100;
    int m_startFrame;
    BhanuKeyframe[] m_keyFrames = new BhanuKeyframe[m_bufferFrames];
    GameManager m_gameManager;
    Rigidbody m_rigidbody;

	void Start() 
    {
        m_gameManager = FindObjectOfType<GameManager>();
        m_rigidbody = GetComponent<Rigidbody>();
        m_startFrame = Time.frameCount;
        //Debug.Log("Start Frame : " + m_startFrame);
	}
    
	void Update() 
    {
		if(Time.timeScale == 0)
            return;

        if(m_gameManager.m_isRecording)
        {
            Record();
        }
        else
        {
            Replay();
        }
	}
    
    void Record()
    {
        m_rigidbody.isKinematic = false;
        int frame = Time.frameCount % m_bufferFrames;
        float time = Time.time;
        m_keyFrames[frame] = new BhanuKeyframe(time, transform.position, transform.rotation);
    }

    void Replay()
    {
        m_rigidbody.isKinematic = true;
        int frame = Time.frameCount % m_bufferFrames; //Fix the bug of reading through all 1000 frames even if we stop at 100 frames
        transform.position = m_keyFrames[frame].m_position;
        transform.rotation = m_keyFrames[frame].m_rotation;
    }
}

/// <summary>
/// Bhanu keyframe is a struct for storing time, rotation & position
/// </summary>
public struct BhanuKeyframe
{
    public float m_frameTime;
    public Quaternion m_rotation;
    public Vector3 m_position;

    public BhanuKeyframe(float time , Vector3 pos , Quaternion rot)
    {
        m_frameTime = time;
        m_position = pos;
        m_rotation = rot;
    }
}
