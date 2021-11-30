using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bikecontroler : MonoBehaviour
{
   public WheelJoint2D wj;
    JointMotor2D Motor;

    public PlayerInput pi;
    

    private void OnEnable()
    {
    }
    void Start()
    {
        pi = new PlayerInput();
       // wj = gameObject.GetComponents<WheelJoint2D>()[1];
        Motor = new JointMotor2D();

        pi.UiInputs.Enable();
        pi.UiInputs.Move.performed += ctx => bikeforward();
        pi.UiInputs.Move.canceled += ctx => bikereverse();
        pi.UiInputs.stop.performed += stp => bikestop();
        pi.UiInputs.stop.canceled += stp => bikestop();
    }
    public bool imbool=false;
    // Update is called once per frame
    void Update()
    {

        //wj.useMotor = false;
        //if(Input.GetKey(KeyCode.D))
        //{
        //    bikeforward();
        //}
        //if (Input.GetKeyUp(KeyCode.D))
        //{

        //    wj.useMotor = false;

        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    bikereverse();

        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{

        //    wj.useMotor = false;

        //}

        if (imbool)
        {
            Motor.motorSpeed -= 200 * Time.deltaTime;
            Motor.maxMotorTorque = 2000;
            wj.useMotor = true;
            wj.motor = Motor;
        }
        else if(!imbool)
        {
           
            //Motor.motorSpeed = 0;
            wj.useMotor = false;
          //  wj.motor = Motor;
        }
        
       

    }

    public void bikereverse()
    {
        imbool = false;
        //Motor.motorSpeed = 0;
        //wj.useMotor = true;
        //wj.motor = Motor;
    }

    public void bikeforward()
    {
        imbool = true;
        //Motor.motorSpeed -= 200*Time.deltaTime;
        //Motor.maxMotorTorque = 2000;
        //wj.useMotor = true;
        //wj.motor = Motor;
    }
    public void bikestop()
    {
        //imbool = false;
        Motor.motorSpeed = 0;
        wj.useMotor = true;
        wj.motor = Motor;
    }
    
}
