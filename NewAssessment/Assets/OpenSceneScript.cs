using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OpenSceneScript : MonoBehaviour
{
    public Button level1Button;
    public Button level2Button;


    // Start is called before the first frame update
    void Start()
    {
        level1Button.onClick.AddListener(() => SceneManager.LoadScene("SampleScene"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
