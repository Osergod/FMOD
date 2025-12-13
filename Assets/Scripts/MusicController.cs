using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using FMOD.Studio;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private EventReference mainSongEvent;
    private EventInstance musicInstance;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        musicInstance = RuntimeManager.CreateInstance(mainSongEvent);
        musicInstance.start();
    }

    public void TogglePause()
    {
        if (!musicInstance.isValid()) return;

        if (isPaused)
        {
            musicInstance.setPaused(false);
            isPaused = false;
        }
        else
        {
            musicInstance.setPaused(true);
            isPaused = true;
        }
    }
}
