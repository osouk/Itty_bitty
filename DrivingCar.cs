using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrivingCar : MonoBehaviour
{

    public GameObject PlayerModl;
    public Transform spawnPosOnCar;
    public GameObject Kamerat;

    public PrometeoCarController CarMove;

    public Transform Player;
    public float DistanceLimit = 3;

    void Start()
    {
        CarMove = GetComponent<PrometeoCarController>();
        CarMove.enabled = false;
        Kamerat.SetActive(false);
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
                    CarMove.enabled = true;
                    PlayerModl.SetActive(false);
                    GameObject instance = Instantiate(PlayerModl, spawnPosOnCar.position, Quaternion.identity);
                    Kamerat.SetActive(true);                                  

                }
            }
        }
    }
}