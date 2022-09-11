using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public AudioClip Sound;
    public float Speed;

    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector2 direction){
        Direction = direction;
    }

    public void DestroyBullet(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        JhonMovement jhonMovement = collision.GetComponent<JhonMovement>();
        GruntScript gruntScript = collision.GetComponent<GruntScript>();

        if (jhonMovement != null){
            jhonMovement.Hit();
        }
        if (gruntScript != null){
            gruntScript.Hit();
        }
        DestroyBullet();
    }

    // private void OnCollisionEnter2D(Collision2D collision) {
        
    // }

}
