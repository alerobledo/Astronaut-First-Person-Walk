using UnityEngine;
using System.Collections;
using UnitySampleAssets.Characters.FirstPerson;

public class FuelItem : MonoBehaviour {

    public float speed = 10f;

    public Transform Player;
    private RigidbodyFirstPersonController playerComponent;

    // Use this for initialization
    void Start () {
        playerComponent = Player.GetComponent<RigidbodyFirstPersonController>();

    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerComponent.chargeFuel(1000);
            Destroy(this);
        }
    }

}