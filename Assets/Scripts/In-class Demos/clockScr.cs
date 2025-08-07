using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class clockScr : MonoBehaviour
{
    public Transform hourHandTrfm;
    public Transform minHandTrfm;
    public float hourDuration = 5;
    public float currentTime = 0;
    public UnityEvent<int> perHour;
    float currentHour;
    clockChime clockChimeScr;
    Coroutine clockCoroutine;
    IEnumerator clockHandCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        clockChimeScr = gameObject.GetComponentInChildren<clockChime>();
        clockCoroutine = StartCoroutine(clockUpdate());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void stopClock()
    {
        if (clockCoroutine != null)
        {
            StopCoroutine(clockCoroutine);
        }
        else
        {
            Debug.Log("Coroutine is null");
        }
        if (clockHandCoroutine != null)
        {
            StopCoroutine(clockHandCoroutine);
        }
        else
        {
            Debug.Log("Coroutine is null");
        }
    }
    public IEnumerator clockUpdate()
    {
        while (true)
        {
            clockHandCoroutine = moveHands();
            yield return StartCoroutine(clockHandCoroutine);
        }
    }

    public IEnumerator moveHands()
    {
        currentTime = 0f;
        while (currentTime <= 4)
        {
            currentTime += Time.deltaTime;
            minHandTrfm.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration;
            hourHandTrfm.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration / 12;
            if (currentTime > hourDuration)
            {
                if (clockChimeScr != null)
                {
                    clockChimeScr.playChime();
                    currentHour += 1;
                    Debug.Log("The current hour is: " + currentHour);
                }
                else
                {
                    Debug.Log("Chime object is null");
                }
            }
            yield return null;
        }
    }
}
