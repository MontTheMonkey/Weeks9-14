using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogScr : formAnimal
{
    public enum Form
    {
        egg, tadpole, frog
    }
    public Form currentForm = Form.egg;
    public Gradient tadpoleGradient;
    public Gradient frogGradient;

    private ParticleSystem butterflyParticles;
    private ParticleSystem.MainModule butterflyModule;

    private void Awake()
    {
        butterflyParticles = GetComponent<ParticleSystem>();
        butterflyModule = butterflyParticles.main;
    }
    
    void Update()
    {
        
    }

    public override void ChangeForm()
    {
        if (currentForm == Form.egg)
        {
            timeInForm = 0f;
            currentForm = Form.tadpole;
            Debug.Log("Changing form to Tadpole");

            butterflyModule.startColor = tadpoleGradient;
        }
        else if (currentForm == Form.tadpole)
        {
            timeInForm = 0f;
            currentForm = Form.frog;
            Debug.Log("Changing form to Frog");
            butterflyModule.startColor = frogGradient;
        }
    }
}
