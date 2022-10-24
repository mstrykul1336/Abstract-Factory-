using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Client : MonoBehaviour
{
    public int NumberOfBodySeg;
    public bool Tamable;
    public int NumberOfBlocks;
    public bool Chest;

    public Scrollbar TamableSlider;
    public Scrollbar Time;
    public Scrollbar ChestSlider;
    public TMP_Dropdown Blocks;
    public TMP_Dropdown Seg;

    private VehicleRequirements requirements;

    // Start is called before the first frame update
    void Start()
    {
        // validate our data

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfBodySeg = NumberOfBodySeg;
        requirements.Tamable = Tamable;
        requirements.NumberOfBlocks = NumberOfBlocks;
        requirements.Chest = Chest;
        IVehicle v = GetVehicle(requirements);
        Debug.Log(v);


        //IVehicle v = new Unicycle();


    }





    // Update is called once per frame
    void Update()
    {
      
    }

    public void HandleInputData(){
        {
            if (Seg.value == 0)
            {
                NumberOfBodySeg = 1;
                Start();
            }

            else if (Seg.value == 1)
            {
               NumberOfBodySeg = 2;
               Start();
            }

            else if (Seg.value == 2)
            {
                NumberOfBodySeg = 3;
                Start();
            }

            else if (Seg.value == 3)
            {
                NumberOfBodySeg = 4;
                Start();
            }
        }
    }

    public void HandleInputData2(){
       {
            if (Blocks.value == 0)
            {
                NumberOfBlocks = 1;
                Start();
            }

            else if (Blocks.value == 1)
            {
               NumberOfBlocks = 2;
               Start();
           }

        }
   }

    public void tamableOn(){
    
        if (TamableSlider.value == 1){

            Tamable = true;
            Start();
        }
        else{
            Tamable = false;
            Start();
        }
    }

    public void cargoOn(){

        if (ChestSlider.value == 1){

            Chest = true;
            Start();
        }
        else{
            Chest = false;
            Start();
        }
    }

    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        // based on requirements.Tamable
        // choose a motorvehicle factory or a cycle factory
        // call create on the factory to get an appropriate vehicle
        // and return it

        //VehicleFactory factory = new VehicleFactory();

        //if (requirements.Tamable)
        //{
        //    return factory.MotorVehicleFactory().Create(requirements);
        //}

        //return factory.CycleFactory().Create(requirements);

        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }
}