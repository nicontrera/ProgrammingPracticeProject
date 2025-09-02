using UnityEngine;

public class DeadZone : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {


        Debug.Log("THE COL TAG IS: " + collision.tag);
        Debug.Log(collision.tag);

        

        PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
        player.Die();

        


    }
}
