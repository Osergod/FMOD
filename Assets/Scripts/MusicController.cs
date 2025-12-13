using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField] private EventReference mainSongEvent;
    [SerializeField] private Slider lowPassSlider;
    [SerializeField] private Slider delaySlider;

    private const string LowPassParam = "LowPassControl";
    private const string DelayParam = "DelayTime";

    private EventInstance musicInstance;

    void Start()
    {
        musicInstance = RuntimeManager.CreateInstance(mainSongEvent);
        musicInstance.start();

        float lpInit = 0f;     
        float delayInit = 0f;  

        lowPassSlider.value = lpInit;
        delaySlider.value = delayInit;

        ApplyLowPass(lpInit);
        ApplyDelay(delayInit);

        lowPassSlider.onValueChanged.AddListener(ApplyLowPass);
        delaySlider.onValueChanged.AddListener(ApplyDelay);

    }

    public void TogglePausePlay()
    {
        if (!musicInstance.isValid()) return;

        bool paused;
        musicInstance.getPaused(out paused);
        musicInstance.setPaused(!paused);
    }

    private void ApplyLowPass(float value)
    {
        musicInstance.setParameterByName(LowPassParam, value);
    }

    private void ApplyDelay(float value)
    {
        musicInstance.setParameterByName(DelayParam, value);
    }

    void OnDestroy()
    {
        if (musicInstance.isValid())
            musicInstance.release();
    }
}
