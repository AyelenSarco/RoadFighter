using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed = 1;
    

   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            /* multiplicando por Time.deltaTime nos aseguramos que sin importar cuantos frames haya, 
            siempre se mueva igual o lo mas parecido posible
                Video explicandolo --> https://www.youtube.com/watch?v=ix6FAPEF_HA&ab_channel=Guinxu
            */
    
            //this.transform.Translate(-Speed * Time.deltaTime ,0,0);
            this.transform.Translate(Vector2.left * Speed * Time.deltaTime);

        }
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            //this.transform.Translate(Speed * Time.deltaTime ,0,0);
            this.transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }
      
    }
}
