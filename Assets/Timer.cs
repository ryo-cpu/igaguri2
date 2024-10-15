using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float m_fTimer;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        m_fTimer += Time.deltaTime;
    }
    void Reset()
    {
        m_fTimer = 0f;
    }
    float ReturnTime()
    {
        return m_fTimer;
    }
}
