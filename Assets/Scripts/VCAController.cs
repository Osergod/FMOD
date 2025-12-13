using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class VCAController : MonoBehaviour
{
    private VCA generalVCA;
    private VCA musicVCA;
    private VCA sfxVCA;

    void Start()
    {
        generalVCA = RuntimeManager.GetVCA("vca:/GeneralVCA");
        musicVCA = RuntimeManager.GetVCA("vca:/MusicVCA");
        sfxVCA = RuntimeManager.GetVCA("vca:/SFXVCA");
    }

    public void SetGeneralVolume(float value) => generalVCA.setVolume(value);
    public void SetMusicVolume(float value) => musicVCA.setVolume(value);
    public void SetSFXVolume(float value) => sfxVCA.setVolume(value);

}
