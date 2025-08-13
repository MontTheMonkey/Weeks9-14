using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterFly : formAnimal
{
    public enum Form
    {
        caterpillar, coccoon, butterfly
    }
    public Form currentForm = Form.caterpillar;
    public Gradient coccoonGradient;
    public Gradient butterflyGradient;

    private ParticleSystem butterflyParticles;
    private ParticleSystem.MainModule butterflyModule;
    private float timeInForm = 0f;

    private void Awake()
    {
        butterflyParticles = GetComponent<ParticleSystem>();
        butterflyModule = butterflyParticles.main;
    }

    void Update()
    {
        FormUpdate();
    }

    public override void ChangeForm()
    {
        if (currentForm == Form.caterpillar)
        {
            timeInForm = 0f;
            currentForm = Form.coccoon;
            Debug.Log("Changing form to Cocoon");

            butterflyModule.startColor = coccoonGradient;
        }
        else if (currentForm == Form.coccoon)
        {
            timeInForm = 0f;
            currentForm = Form.butterfly;
            Debug.Log("Changing form to Butterfly");
            butterflyModule.startColor = butterflyGradient;
        }
    }
}
