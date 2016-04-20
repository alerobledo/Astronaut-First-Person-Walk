using UnityEngine;
using System.Collections;

public class InfoScreen : MonoBehaviour {

    public static InfoScreen Instance { get; set; }

    public Sprite[] Images;

    public GameObject InfoScreenPanel;
    public GameObject InfoScreenImage;

    private UnityEngine.UI.Image imageComponent;
    private System.Random rnd = new System.Random();

    public void DisplayScreen() {

        if (imageComponent != null) {
            imageComponent.sprite = Images[rnd.Next(0, Images.Length - 1)];
            InfoScreenPanel.SetActive(true);
        }
            

    }

    public void HideScreen() {
        InfoScreenPanel.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        InfoScreen.Instance = this;

        imageComponent = InfoScreenImage.GetComponent< UnityEngine.UI.Image >();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown) {
            HideScreen();
        }
	}
}
