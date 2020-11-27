using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSwitch : MonoBehaviour
{
    private AudioSource audioSource;
    public Transform items;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayBG()
    {
        Camera.main.GetComponent<AudioSource>().enabled = true;
    }

    public void DestoryItems()
    {
        Destroy(items);
    }
}
