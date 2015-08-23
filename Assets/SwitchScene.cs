using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

    public string nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadNext()
    {
        Application.LoadLevel(nextScene);
    }
}
