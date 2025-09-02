using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public PlayerMovement target;
    // public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform.position.z = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Debug.Log("camara sin player");
            target = Object.FindAnyObjectByType<PlayerMovement>();
            // target = Instantiate(playerPrefab, respawnPoint.position, quaternion.identity);
        }

        if (target != null)
            {
                transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - 1);

            }
    }
}
