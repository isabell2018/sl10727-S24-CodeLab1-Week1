using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    public Manager manager;
    private Rigidbody rb;
    public float t = 0.125f;//speed of the enemy

    public TextMeshProUGUI GameOverText;
    public GameObject GameOver;
    public GameObject score;
    public float scorenumber;
    private float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
        GameOver.SetActive(false);
        score.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        
        //make enemy move towards the player
        Vector3 newp = Vector3.MoveTowards(rb.transform.position, player.transform.position,t);
        rb.transform.position = new Vector3(newp.x,newp.y, newp.z);
        
        //
    }

    private void OnCollisionEnter(Collision other)
    {
        //if collide with player, game over
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.activeSelf)
            {
                Debug.Log("Game Over");
                player.SetActive(false);
                GameOver.SetActive(true);
                score.SetActive(false);
                GameOverText.text = "Game Over! Score: " + manager.time.ToString("F0");
            }
        }
    }
}
