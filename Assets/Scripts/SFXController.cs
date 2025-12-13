using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    [SerializeField] private EventReference sfxEvent;

    public void PlaySFX()
    {
        RuntimeManager.PlayOneShot(sfxEvent);
    }
}
