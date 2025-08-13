using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formAnimalManager : MonoBehaviour
{
    public List<formAnimal> formAnimalsList = new List<formAnimal>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < formAnimalsList.Count; i++)
        {
            formAnimalsList[i].ChangeForm();
            //formAnimalsList[i].ChangeForm();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
