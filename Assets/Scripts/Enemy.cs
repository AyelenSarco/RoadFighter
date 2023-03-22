using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float Speed;

   
   
    void Update()
    {
        transform.Translate(0, -(Speed * Time.deltaTime), 0, Space.World);
        
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
