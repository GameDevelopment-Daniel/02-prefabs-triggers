using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class bombScript : MonoBehaviour
{
    [SerializeField] InputAction bomb = new InputAction(type: InputActionType.Button);
    [SerializeField] int bombsNumber;
    void OnEnable()
    {
        bomb.Enable();
    }

    void OnDisable()
    {
        bomb.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Text").GetComponent<TextMeshProUGUI>().text = bombsNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (bombsNumber > 0 && bomb.WasPressedThisFrame())
        {
            Debug.Log("wasddd");
            bombsNumber--;
            GameObject.Find("Text").GetComponent<TextMeshProUGUI>().text = bombsNumber.ToString();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            {
                Destroy(enemy);
            }

        }
    }
}
