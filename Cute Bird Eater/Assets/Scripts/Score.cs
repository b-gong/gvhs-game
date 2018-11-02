using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //Variables

    //Text variables
    public Text scoreText;
    public int startingText = 0;
    //Collider variables
    public BoxCollider2D birdCollider;
    public BoxCollider2D topCollider;
    public BoxCollider2D bottomCollider;
    public BoxCollider2D centerCollider;
    //Trigger variables
    private bool topColliderTrigger = false;
    private bool bottomColliderTrigger = false;
    private bool centerColliderTrigger = false;
    //GameObjects
    public Transform birdPrefab;
    public Transform spawnPoint;
    public SpringJoint2D birdHook;
    public GameObject bird;
    public Button respawnButton;

    //Score and Bird Respawn Handling

    //Do this once at beginning
    private void Start()
    {
        scoreText.text = startingText.ToString("0");
    }
    //Do this once per frame
    void Update () {

        //Check if bird and mouth are touching
        if (birdCollider.IsTouching(topCollider))
        {
            topColliderTrigger = true;
        }
        if (birdCollider.IsTouching(bottomCollider))
        {
            bottomColliderTrigger = true;
        }
        if (birdCollider.IsTouching(centerCollider))
        {
            centerColliderTrigger = true;
        }

        //Increase Score and Respawn Bird
        if (topColliderTrigger == true)
        {
            startingText = startingText + 1;
            scoreText.text = startingText.ToString("0");
            topColliderTrigger = false;
            bird.SetActive(false);
            bird.transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
            birdHook.enabled = true;
            bird.SetActive(true);
        }
        if (bottomColliderTrigger == true)
        {
            startingText = startingText + 1;
            scoreText.text = startingText.ToString("0");
            bottomColliderTrigger = false;
            bird.SetActive(false);
            bird.transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
            birdHook.enabled = true;
            bird.SetActive(true);
        }
        if (centerColliderTrigger == true)
        {
            startingText = startingText + 1;
            scoreText.text = startingText.ToString("0");
            centerColliderTrigger = false;
            bird.SetActive(false);
            bird.transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
            birdHook.enabled = true;
            bird.SetActive(true);
        }
        //Respawn Button
        
    }
}
