using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public Transform birdPrefab;
    public Transform spawnPoint;
    public SpringJoint2D birdHook;
    public GameObject bird;
    public Button respawnButton;

    public void Respawn() {
        bird.SetActive(false);
        bird.transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
        birdHook.enabled = true;
        bird.SetActive(true);
    }

}
