using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Winning : MonoBehaviour
{
    private float speed = 30;
    public static bool fly = false;
    public static bool collectedAll = false;
    public static GameObject messageBox;


    // Start is called before the first frame update
    void Start()
    {
        messageBox = GameObject.Find("GasTankCanvas");
        messageBox.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if(fly == true && collectedAll == true){
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
            Debug.Log("flying");
        }
    }

    public static void showMessage()
    {
        messageBox.SetActive(true);
          Destroy(messageBox, 4);

    }
}
