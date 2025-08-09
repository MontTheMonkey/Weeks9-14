using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryAssemble : MonoBehaviour
{
    public float buildDuration = 3f;
    float currentTime;
    Vector3 alteredScale;
    AnimationCurve aniCurve;
    Coroutine buildCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        buildCoroutine = StartCoroutine(constructFactory());
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = alteredScale;
    }

    public IEnumerator constructFactory()
    {
        while (currentTime < buildDuration)
        {
            currentTime += Time.deltaTime;
            alteredScale = Vector3.one * aniCurve.Evaluate(currentTime / buildDuration);
            yield return null;
        }
    }
}
