﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe1Exit : MonoBehaviour
{
    public AudioSource PipeSound;
    public GameObject FadeScreen;
    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject PipeEntry;
    public GameObject MainPlayer;

    IEnumerator OnTriggerEnter(Collider col)
    {
        PipeSound.Play();
        FadeScreen.SetActive(true);
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495f);
        FadeScreen.GetComponent<Animator>().enabled = false;
        MainCam.SetActive(true);
        SecondCam.SetActive(false);
        MainPlayer.transform.position = new Vector3(33.05f, 1, 0.5f);
        PipeEntry.GetComponent<Animator>().enabled = true;
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495f);
        FadeScreen.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(1);
        PipeEntry.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}