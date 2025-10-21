using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private string gamelevel = "level";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gamestartbutton()
    {
        SceneManager.LoadScene(gamelevel);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }

}
