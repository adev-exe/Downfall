using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public GameObject titleScreen;
    private Button button; 
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>(); 
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartGame()
    {
        isGameActive = true;
        titleScreen.SetActive(false);
    }
    
}
