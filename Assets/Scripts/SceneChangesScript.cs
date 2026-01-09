using UnityEngine;
using UnityEngine . SceneManagement; 

public class Chan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeScene()
    {
        SceneManager.LoadScene("Story"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
