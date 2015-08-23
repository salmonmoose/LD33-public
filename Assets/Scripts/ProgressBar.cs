using UnityEngine;
using System.Collections;

public class ProgressBar : MonoBehaviour {

    float parentWidth;

    public float percentage = 50.0f;

    // Use this for initialization
	void Start () {
        parentWidth = transform.parent.gameObject.GetComponent<RectTransform>().rect.width;
	}
	
	// Update is called once per frame
	void Update () {
	    if (percentage < 0)
        {
            percentage = 0.0f;
        } else if (percentage > 100)
        {
            percentage = 100.0f;
        }

        float setWidth = (percentage / 100.0f) * parentWidth;
        Rect tempRect = GetComponent<RectTransform>().rect;

        GetComponent<RectTransform>().sizeDelta = new Vector2(setWidth, tempRect.height);
	}
}
