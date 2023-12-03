using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flying : MonoBehaviour
{
    private Vector3 direction;

    public float strength = 20f;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(0,5);
        }

        /*if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began){
                direction = Vector3.up * strength;
            }
        }*/
        //transform.position += direction * Time.deltaTime;
    }

        private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "EndObject"){
            Debug.Log("player died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

