using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;
        if (time > 10 && player.activeSelf)
        {
            time = 0;
            Debug.Log("spawn!");
            Instantiate(enemy,enemy.transform.position,enemy.transform.rotation);
            enemy.transform.position = new Vector3(0f, 0f, 0f);
        }
       
    }
}
