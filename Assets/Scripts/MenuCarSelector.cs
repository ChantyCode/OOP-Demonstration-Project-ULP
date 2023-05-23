 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCarSelector : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField] private GameObject[] vehicles;
    private int m_VehicleSelected = 0;
    public int vehicleSelected
    { 
        get { return m_VehicleSelected; }
        set 
        {
            if (value < 0 || value > 2)
            {
                Debug.LogError("Wrong index for car selection");
            }else{
                m_VehicleSelected = value;
            }
        }
    }
    public void SelectIceTruck()
    {
        m_VehicleSelected = 0;
    }
    public void SelectMustang()
    {
        m_VehicleSelected = 1;
    }
    public void SelectMinivan()
    {
        m_VehicleSelected = 2; 
    }
    public void SaveChoice()
    {
        PlayerPrefs.SetInt("selectedCar", m_VehicleSelected);
    }
}
