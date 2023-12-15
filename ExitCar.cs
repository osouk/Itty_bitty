using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class ExitCar : MonoBehaviour
{

    public GameObject cameraObject2;
    public GameObject PlayerModl;
    public Transform spawnPosOnCar;
    public GameObject Kamerat;


    public PrometeoCarController CarMove;


    void Start()
    {
        cameraObject2 = GameObject.Find("Maincamera");
        CarMove = GetComponent<PrometeoCarController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Ulostaudun");
            PlayerModl.transform.position = spawnPosOnCar.transform.position;
            PlayerModl.SetActive(true);
            CarMove.enabled = false;
            Kamerat.SetActive(false);


            

        }
    }
}
