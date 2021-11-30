using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class carcontroler : MonoBehaviour
{
    public static carcontroler instance;
    //public Rigidbody2D ft;
    public Rigidbody2D bt;
    public Rigidbody2D vehicle;
    public float speed;
    public float movement;
    public float gas = 1f;
    public float gasconsumption = 0.1f;
    public Image gasimage;
    public AudioSource vehiclesound;
    
    // Start is called before the first frame update
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
         vehiclesound= GetComponent<AudioSource>();
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            vehiclesound.Play();
        }
        gasimage.fillAmount = gas;
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (gas > 0)
        {
           
            //ft.AddTorque(-movement*speed*Time.fixedDeltaTime);
            bt.AddTorque(-movement * speed * Time.fixedDeltaTime);
            vehicle.AddTorque(movement * speed * Time.fixedDeltaTime);
        }
        gas = gas - gasconsumption * Time.fixedDeltaTime * Mathf.Abs(movement);
    }
}
