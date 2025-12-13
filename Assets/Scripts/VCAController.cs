using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

public class VCAController : MonoBehaviour
{
    private VCA generalVCA;
    private VCA musicVCA;
    private VCA sfxVCA;

    [SerializeField] private Slider generalSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    void Start()
    {
        // Obtener referencias a los VCAs
        generalVCA = RuntimeManager.GetVCA("vca:/GeneralVCA");
        musicVCA = RuntimeManager.GetVCA("vca:/MusicVCA");
        sfxVCA = RuntimeManager.GetVCA("vca:/SFXVCA");

        // Inicializar sliders al 50%
        generalSlider.value = 0.5f;
        musicSlider.value = 0.5f;
        sfxSlider.value = 0.5f;

        // Aplicar valores iniciales a FMOD
        SetGeneralVolume(0.5f);
        SetMusicVolume(0.5f);
        SetSFXVolume(0.5f);

        // Conectar eventos de los sliders
        generalSlider.onValueChanged.AddListener(SetGeneralVolume);
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    public void SetGeneralVolume(float value) => generalVCA.setVolume(value);
    public void SetMusicVolume(float value) => musicVCA.setVolume(value);
    public void SetSFXVolume(float value) => sfxVCA.setVolume(value);

}
