using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrivingCar : MonoBehaviour
{
    public GameObject Drivable;
    public GameObject NotDrivable;
    public PlayerMovement FPSInput;
    public GameObject cameraObject;
    public GameObject virtualCameraObject;
    public GameObject cameraObject2;
    public GameObject PlayerModl;
    public Transform spawnPosOnCar;
    public Transform carSpawn;

    public Transform Player;
    public float DistanceLimit = 3;

    void Start()
    {
        FPSInput = GetComponent<PlayerMovement>();
        cameraObject = GameObject.Find("kamera");
        virtualCameraObject = GameObject.Find("VirtualCamra");
        cameraObject2 = GameObject.Find("Maincamera");
    }

    void OnMouseOver()
    {
        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < DistanceLimit)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Elä Töki");
                    NotDrivable.SetActive(false);
                    Drivable.SetActive(true);
                    PlayerModl.SetActive(false);
                    GameObject instance = Instantiate(PlayerModl, spawnPosOnCar.position, Quaternion.identity);
                  //  GameObject instance2 = Instantiate(NotDrivable, carSpawn.position, Quaternion.identity);
                }
            }
        }
    }






}