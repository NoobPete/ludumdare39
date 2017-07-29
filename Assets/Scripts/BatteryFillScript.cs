using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryFillScript : MonoBehaviour {
    public GameObject fill;
    public Color fillColor;
    public float fillAmount;
    public float fillOffset;

    private SpriteRenderer spriteRenderer;

    private Vector3 scaleFull;
    private Vector3 positionFull;

    // Use this for initialization
    void Start () {
        spriteRenderer = fill.GetComponent<SpriteRenderer>();
        spriteRenderer.color = fillColor;

        scaleFull = fill.transform.localScale;
        positionFull = fill.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        fill.transform.localScale = new Vector3(scaleFull.x, scaleFull.y/ 100f * fillAmount);
        fill.transform.localPosition = new Vector3(positionFull.x, positionFull.y + (100-fillAmount) * fillOffset, positionFull.z);

        spriteRenderer.color = fillColor;
    }

    public bool ChangeLevel(float amaount)
    {
        fillAmount = Mathf.Clamp(fillAmount+amaount, 0, 100);

        if (fillAmount == 0)
        {
            return true;
        }

        return false;
    }
}
