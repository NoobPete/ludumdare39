using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour {
    public GameObject playPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButton()
    {
        playPanel.SetActive(!playPanel.activeSelf);
    }

    public void SetPlayerCount(int count)
    {
        PlayerPrefs.SetInt("PlayerCount", count);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void OptionsButton()
    {

    }
}
