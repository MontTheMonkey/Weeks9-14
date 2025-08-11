using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowScr : MonoBehaviour
{
    ParticleSystem snowParticles;
    // Start is called before the first frame update
    void Start()
    {
        snowParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            toggleSnow();
        }
    }

    void toggleSnow()
    {
        if (snowParticles.isPlaying)
        {
            snowParticles.Stop();
        }
        else
        {
            snowParticles.Play();
        }
            
    }
}
