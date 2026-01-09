using UnityEngine;
using UnityEngine . SceneManagement; 

public class Reverse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeScene()
    {
        SceneManager.LoadScene("Desert"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
