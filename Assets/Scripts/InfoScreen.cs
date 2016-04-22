using UnityEngine;
using System.Collections;

public class InfoScreen : MonoBehaviour {

    public static InfoScreen Instance { get; set; }

    public Sprite[] Images;

    public GameObject InfoScreenPanel;
    public GameObject InfoScreenImageL;
    public GameObject InfoScreenImageR;

    private UnityEngine.UI.Image imageComponentL;
    private UnityEngine.UI.Image imageComponentR;
    private System.Random rnd = new System.Random();

    public void DisplayScreen() {

        if (imageComponentL != null && imageComponentR != null) {
            int imgIndex = rnd.Next(0, Images.Length - 1);
            imageComponentL.sprite = Images[imgIndex];
            imageComponentR.sprite = Images[imgIndex];
            InfoScreenPanel.SetActive(true);
        }
            

    }

    public void HideScreen() {
        InfoScreenPanel.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        InfoScreen.Instance = this;

        imageComponentL = InfoScreenImageL.GetComponent< UnityEngine.UI.Image >();
        imageComponentR = InfoScreenImageR.GetComponent<UnityEngine.UI.Image>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown) {
            HideScreen();
        }
	}
}
