using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formAnimal : MonoBehaviour
{
    public float formDuration;
    protected float timeInForm = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FormUpdate()
    {
        timeInForm += Time.deltaTime;
        if (timeInForm > formDuration)
        {
            ChangeForm();
        }
    }

    public virtual void ChangeForm()
    {
        Debug.Log("Lets go!");
    }
}
