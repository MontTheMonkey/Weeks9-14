using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockChime : MonoBehaviour
{
    public AudioSource chimeSound;
    // Start is called before the first frame update
    void Start()
    {
        chimeSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playChime()
    {
        chimeSound.Play();
        Debug.Log("Clock chime has played");
    }
}
