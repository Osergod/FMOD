using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMEnu : MonoBehaviour
{
    [SerializeField] private EventReference mainSongSnapshot;
    [SerializeField] private EventReference pauseSnapshot;
    [SerializeField] private Canvas menuPausa;

    private EventInstance mainSongInstance;
    private EventInstance pauseInstance;

    // Start is called before the first frame update
    void Start()
    {
        mainSongInstance = RuntimeManager.CreateInstance(mainSongSnapshot);
        mainSongInstance.start();

        pauseInstance = RuntimeManager.CreateInstance(pauseSnapshot);
    }

    // Update is called once per frame
    void Update()
    {
        if (menuPausa.enabled)
        {
            pauseInstance.start();
        }
        else
        {
            pauseInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
}
