using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    [SerializeField] float moveSpeed=0;
    [SerializeField] GameObject ipucuPaneli;
    private void Update()
    {
        CharacterMove();
    }
    void CharacterMove()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag=="Enemy")
        {
            ipucuPaneli.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
      
    }
}
