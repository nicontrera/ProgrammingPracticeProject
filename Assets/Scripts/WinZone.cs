using UnityEngine;
using UnityEngine.SceneManagement;


public class WinZone : MonoBehaviour
{
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.R))
        {
           SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered win zone");
        SceneManager.LoadScene("winScene", LoadSceneMode.Single);



    }
}
