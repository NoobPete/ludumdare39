using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuControllerScript : MonoBehaviour {
    public GameObject playPanel;
    public GameObject optionsPanel;
    public AudioSource clickSound;
    public AudioMixer mixer;

	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButton()
    {
        playPanel.SetActive(!playPanel.activeSelf);
        optionsPanel.SetActive(false);
        playClickSound();
    }

    private void playClickSound()
    {
        clickSound.Play();
    }

    public void SetPlayerCount(int count)
    {
        PlayerPrefs.SetInt("PlayerCount", count);
        playClickSound();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        playClickSound();
    }

    public void QuitButton()
    {
        Application.Quit();
        playClickSound();
    }

    public void OptionsButton()
    {
        playPanel.SetActive(false);
        optionsPanel.SetActive(!optionsPanel.activeSelf);
        playClickSound();
    }

    public void SetMasterLevel(float level)
    {
        mixer.SetFloat("MasterVol", -80 + level * 80f);
    }

    public void SetMusicLevel(float level)
    {
        mixer.SetFloat("MusicVolume", -80 + level * 80f);
    }

    public void SetMSELevel(float level)
    {
        mixer.SetFloat("MSEVol", -80 + level * 80f);
    }

    public void SetSELevel(float level)
    {
        mixer.SetFloat("SEVol", -80 + level * 80f);
    }
}
