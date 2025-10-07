using UnityEngine;

public class slime : MonoBehaviour
{

    public Game_Manager manager;
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            manager.PerderVidas(1);
        }
    }
}
