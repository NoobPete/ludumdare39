using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonColorBasedOnLevelScript : MonoBehaviour {
    public int highlightOn;
    public Color selected;
    public Color notSelected;
    private Image button;

    // Use this for initialization
    void Start()
    {
        button = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("LevelSelected") == highlightOn)
        {
            button.color = selected;
        }
        else
        {
            button.color = notSelected;
        }
    }
}
