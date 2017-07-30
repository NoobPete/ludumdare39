using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour {
    public GameObject playPanel;
    public AudioSource clickSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButton()
    {
        playPanel.SetActive(!playPanel.activeSelf);
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

        playClickSound();
    }
}
