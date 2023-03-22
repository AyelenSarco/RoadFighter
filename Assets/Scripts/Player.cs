using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float Speed = 1;
    [SerializeField] private GameManager manager;
    [SerializeField] private float maxDistance;
    void Update()
    {
        CheckInput();
        
    }

    private void CheckInput(){
         /* multiplicando por Time.deltaTime nos aseguramos que sin importar cuantos frames haya, 
            siempre se mueva igual o lo mas parecido posible
                Video explicandolo --> https://www.youtube.com/watch?v=ix6FAPEF_HA&ab_channel=Guinxu
            */
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            
            //quick solution because we do not work the movement of the player with physics:
            if (transform.position.x > -maxDistance) {
                this.transform.Translate(Vector2.left * Speed * Time.deltaTime);
            }
        }
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            if (transform.position.x < maxDistance) {
                this.transform.Translate(Vector2.right * Speed * Time.deltaTime);
            }
        }
      
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        manager.OnLose();
        Destroy(this.gameObject);
    }

    
}
