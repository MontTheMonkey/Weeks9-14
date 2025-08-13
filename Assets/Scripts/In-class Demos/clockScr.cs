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
    Coroutine clockHandCoroutine;
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
            clockHandCoroutine = StartCoroutine(moveHands());
            yield return clockHandCoroutine;
        }
    }

    public IEnumerator moveHands()
    {
        currentTime = 0f;
        while (currentTime < hourDuration)
        {
            currentTime += Time.deltaTime;
            minHandTrfm.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration;
            hourHandTrfm.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration / 12;
            if (currentTime > hourDuration)
            {
                if (clockChimeScr != null)
                {
                    currentHour += 1;
                    for (int i = 0; i < currentHour; i++)
                    {
                        clockChimeScr.playChime();
                        yield return new WaitForSeconds(clockChimeScr.chimeFile.length);
                        //clockChimeScr.chimeFile.length
                    }
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
