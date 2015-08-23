using UnityEngine;
using System.Collections;

public class BeagleController : MonoBehaviour {

    public float wagStrength = 2.0f;
    public float wagDieOff = 1.0f;

    private float lastInput = 0;

    private float target = 100.0f;
    private float status = 0.0f;

    public GameObject progress;

    public GameObject wagPanel;
    public GameObject noticePanel;
    public GameObject blackoutPanel;

    public bool finalScene;
    
	// Use this for initialization
	void Start () {
        if (!finalScene)
        {
            ShowWag();
        }
	}
	
    void ShowWag()
    {
        wagPanel.GetComponent<Animator>().SetTrigger("ShowPanel");
    }

    void Blackout()
    {
        blackoutPanel.GetComponent<Animator>().SetTrigger("FadeToBlack");
    }

	// Update is called once per frame
	void Update () {
        if(!finalScene)
        {
            if (status > target)
            {
                wagDieOff = 0.0f;
                noticePanel.GetComponent<Animator>().SetTrigger("ShowPanel");
                Invoke("Blackout", 5);
            }
        }

        if ((lastInput < 0 && Input.GetAxis("Horizontal") > 0) || (lastInput >= 0 && Input.GetAxis("Horizontal") < 0))
        {
            lastInput = Input.GetAxis("Horizontal");
            status = status += wagStrength;
        }

        status = status -= wagDieOff;

        if (finalScene && status > 75)
        {
            status = status - 5;
        }

        if (status < 0)
        {
            status = 0;
        }

        progress.GetComponent<ProgressBar>().percentage = status;
	}
}
