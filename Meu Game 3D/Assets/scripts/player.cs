using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  public int velocidade = 10;
    public Rigidbody rb;

  
    void Start()
    {
      Debug.Log("star");
      TryGetComponent(out rb);
    }

    void Update()
    {
        Debug.Log("update");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(x, 0, y);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
    }
}
