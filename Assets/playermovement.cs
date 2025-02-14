using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour
{
    public float jump;
    private Rigidbody2D rb;
    public bool isGrounded;
    public GameObject RatStanding;
    public GameObject RatCrouching;

    void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jump);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) && isGrounded)
        {
            RatStanding.SetActive(false);
            RatCrouching.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            RatStanding.SetActive(true);
            RatCrouching.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy")) 
        {
            SceneManager.LoadScene(0);
        }
    }
}
