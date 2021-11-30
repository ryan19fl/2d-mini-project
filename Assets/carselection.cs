using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carselection : MonoBehaviour
{
    public GameObject[] car;
    public int selectedcar = 0;
    public void nextcar()
    {
        car[selectedcar].SetActive(false);
        selectedcar = (selectedcar + 1) % car.Length;
        car[selectedcar].SetActive(true);
    }
    public void previouscar()
    {
        car[selectedcar].SetActive(false);
        selectedcar--;
        if(selectedcar<0)
        {
            selectedcar += car.Length;
        }
        car[selectedcar].SetActive(true);
    }
    public void startgame()
    {
        PlayerPrefs.SetInt("selectedcar", selectedcar);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
