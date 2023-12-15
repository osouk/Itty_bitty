using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class ExitCar : MonoBehaviour
{
    public GameObject Drivable;
    public GameObject NotDrivable;
    public GameObject cameraObject2;
    public GameObject PlayerModl;
    public Transform spawnPosOnCar;
    public Transform carSpawn;


    void Start()
    {
        cameraObject2 = GameObject.Find("Maincamera");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Ulostaudun");
           NotDrivable.transform.position = Drivable.transform.position;
            PlayerModl.transform.position = spawnPosOnCar.transform.position;           
            NotDrivable.SetActive(true);
            Drivable.SetActive(false);
            PlayerModl.SetActive(true);
            //  cameraObject2.SetActive(true);
           // GameObject instance2 = Instantiate(PlayerModl, spawnPosOnCar.position, Quaternion.identity);
            
        }
    }
}
