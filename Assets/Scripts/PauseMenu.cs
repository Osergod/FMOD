using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private EventReference pauseSnapshot;
    [SerializeField] Canvas menuPausa;

    private EventInstance pauseInstance;

    void Start()
    {
        pauseInstance = RuntimeManager.CreateInstance(pauseSnapshot);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isActive = menuPausa.gameObject.activeSelf;
            menuPausa.gameObject.SetActive(!isActive);

            RuntimeManager.PauseAllEvents(!isActive);
        }
    }
}
