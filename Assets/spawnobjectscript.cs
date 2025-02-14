using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobjectscript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Gamemanager gm;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Gamemanager>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 6) 
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left * (speed + gm.speedMultiplier);
    }
}
