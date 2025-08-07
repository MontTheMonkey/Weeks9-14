using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScr : MonoBehaviour
{
    public AnimationCurve aniCurve;
    public float growthDuration = 3;
    float currentTime = 0;
    public List<Transform> appleTransforms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void startGrowth()
    {
        StartCoroutine(treeGrowth());
    }

    public IEnumerator treeGrowth()
    {
        while (currentTime < growthDuration)
        {
            currentTime += Time.deltaTime;
            transform.localScale = Vector3.one * aniCurve.Evaluate(currentTime / growthDuration);
            yield return null;
        }
        int i = 0;
        currentTime = 0;
        while (currentTime < growthDuration && i < appleTransforms.Count)
        {
            currentTime += Time.deltaTime;
            appleTransforms[i].localScale = Vector3.one * aniCurve.Evaluate(currentTime / growthDuration);
            yield return null;
            if (currentTime >= growthDuration)
            {
                i++;
                currentTime = 0;
            }
        }
        currentTime = 0;
    }
}
