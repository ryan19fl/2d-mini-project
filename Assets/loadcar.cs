using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class loadcar : MonoBehaviour
{
    public GameObject[] carprefbs;
    public Transform spawnpoint;
    
    // Start is called before the first frame update
    void Start()
    {
        int selectedcar = PlayerPrefs.GetInt("selectedcar");
        GameObject prefab = carprefbs[selectedcar];
        GameObject obj = Instantiate(prefab, spawnpoint.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
