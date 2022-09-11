using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    
    public GameObject bulletPrefap;
    public GameObject Jhon;
    private int health = 3;
    
    private float LastShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Jhon == null) return;

        Vector3 direction = Jhon.transform.position - transform.position;
        if (direction.x > 0.0f) transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        else transform.localScale = new Vector3(-1.0f,1.0f,1.0f);

        float distance = Mathf.Abs(Jhon.transform.position.x - transform.position.x);

        if(distance < 1.0f && Time.time > LastShoot + 0.25f){
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot(){
        
        Vector3 direction;

        if (transform.localScale.x == 1.0f) direction = Vector2.right;
        else direction = Vector2.left;
        
        GameObject bullet = Instantiate(bulletPrefap, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<bulletScript>().SetDirection(direction);
    }

        public void Hit(){
        health = health - 1;
        if (health == 0){
            Destroy(gameObject);
        }
    }

}
