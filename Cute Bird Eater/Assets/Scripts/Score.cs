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
    public Transform birdPrefab;
    public Vector2 spawnPoint;
    public SpringJoint2D birdHook;

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

        //Increase Score
        if (topColliderTrigger == true)
        {
            scoreText.text = startingText++.ToString("0");
            topColliderTrigger = false;
            birdPrefab.transform.position = spawnPoint;
        }
        if (bottomColliderTrigger == true)
        {
            scoreText.text = startingText++.ToString("0");
            bottomColliderTrigger = false;
            birdPrefab.transform.position = spawnPoint;
        }
        if (centerColliderTrigger == true)
        {
            startingText++;
            startingText++;
            scoreText.text = startingText.ToString("0");
            centerColliderTrigger = false;
            birdPrefab.transform.position = spawnPoint;
        }
    }
}
