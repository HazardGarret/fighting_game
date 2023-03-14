using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public PlayerController owner;
    public int damage;
    public GameObject hitEffect;
    public AudioSource audio;
    public AudioClip hitsnd;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(Instantiate(hitEffect, transform.position, Quaternion.identity), 1.0f);
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().TakeDamage(damage, owner);
        }
        Destroy(gameObject);
    }

    public void setOwner(PlayerController owner_new)
    {
        owner = owner_new;
    }
}
