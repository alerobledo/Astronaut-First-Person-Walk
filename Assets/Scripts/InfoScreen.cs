using UnityEngine;
using System.Collections;

public class InfoScreen : MonoBehaviour {

    public static InfoScreen Instance { get; set; }

    public Texture2D[] Images;

    public GameObject InfoScreenPanel;

    public void DisplayScreen() {
        InfoScreenPanel.SetActive(true);
    }

    public void HideScreen() {
        InfoScreenPanel.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        InfoScreen.Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
