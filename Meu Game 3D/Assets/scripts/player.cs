using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using static UnityEngine.Debug;

public class player : MonoBehaviour
{
    public int velocidade = 4;
    public int forcaPulo = 35;
    public bool noChão;
    
    private Rigidbody rb;


    void Start()
    {
       Debug.Log("star");
        TryGetComponent(out rb);
    }

   private void onCollisionEnter(Collision)
    {
        
    }

    void Update()
    {
        Log("update");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(Vector3.up * (float)ForceMode.Impulse);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            }
            
            
            
            
            
        }
        
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        
    }
}
                

            