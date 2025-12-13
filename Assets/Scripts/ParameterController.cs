using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class ParameterController : MonoBehaviour
{
    [SerializeField] private EventReference mainSongEvent;
    private EventInstance musicInstance;

    void Start()
    {
        musicInstance = RuntimeManager.CreateInstance(mainSongEvent);
        musicInstance.start();
    }

    public void SetFilter(float value)
    {
        musicInstance.setParameterByName("FilterParam", value);
    }

    public void SetReverb(float value)
    {
        musicInstance.setParameterByName("ReverbParam", value);
    }
}
