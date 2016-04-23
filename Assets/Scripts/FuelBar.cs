using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnitySampleAssets.Characters.FirstPerson;

public class FuelBar : MonoBehaviour {

    public Sprite[] images;
    public Transform fuelImageGameObjectL;
    public Transform fuelImageGameObjectR;

    private Image imageComponentL;
    private Image imageComponentR;

    public Transform player;
    private RigidbodyFirstPersonController playerScript;

    // Use this for initialization
    void Start () {
        imageComponentL = fuelImageGameObjectL.GetComponent<Image>();
        imageComponentR = fuelImageGameObjectR.GetComponent<Image>();
        playerScript = player.GetComponent<RigidbodyFirstPersonController>();
    }
	
	// Update is called once per frame
	void Update () {

        var fuelPercent = playerScript.getFuelPercent();
//        print(fuelPercent);
        imageComponentL.sprite = images[fuelPercent];
        imageComponentR.sprite = images[fuelPercent];
    }
}
