using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonColorBasedOnSelectedPlayerCountScript : MonoBehaviour {
    public int highlightOn;
    public Color selected;
    public Color notSelected;
    private Image button;

	// Use this for initialization
	void Start () {
        button = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt("PlayerCount") == highlightOn)
        {
            button.color = selected;
        } else
        {
            button.color = notSelected;
        }
	}
}
