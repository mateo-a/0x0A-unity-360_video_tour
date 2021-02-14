
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Exit");
        }
    }
}
