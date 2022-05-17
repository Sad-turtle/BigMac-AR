using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlayMusic : MonoBehaviour
{
    public VirtualButtonBehaviour myVb;
    public GameObject target;
    public AudioSource violin;


    private void Start()
    {
        myVb.RegisterOnButtonPressed(onButtonPressed);
        myVb.RegisterOnButtonReleased(onButtonReleased);
        violin = target.GetComponent<AudioSource>();
        violin.Stop();

    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        violin.Play();

    }
    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        violin.Stop();
    }
}
