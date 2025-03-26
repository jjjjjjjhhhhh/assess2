using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlUI_1 : MonoBehaviour
{
    public Button leftRotateButton;
    public Button rightRotateButton;
    public Button scaleUpButton;
    public Button scaleDownButton;
    public Button moveForwardButton;
    public Button moveBackwardButton;
    public Button resetButton;
    public Button mainMenuButton;

    private Vector3 startPosition;
    private Vector3 startScale;
    private Vector3 startRotation;
    void Start()
    {
        startPosition = transform.position;
        startScale = transform.localScale;
        startRotation = transform.rotation.eulerAngles;

        leftRotateButton.onClick.AddListener(LeftRotate);
        rightRotateButton.onClick.AddListener(RightRotate);
        scaleUpButton.onClick.AddListener(ScaleUp);
        scaleDownButton.onClick.AddListener(ScaleDown);
        moveForwardButton.onClick.AddListener(MoveForward);
        moveBackwardButton.onClick.AddListener(MoveBackward);
        resetButton.onClick.AddListener(Reset);
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("1_0");
    }

    public void Reset()
    {
        transform.position = startPosition;
        transform.localScale = startScale;
        transform.rotation = Quaternion.Euler(startRotation);
    }

    public void LeftRotate()
    {
        Rotate.Instance.RotateObject(transform.gameObject, Vector3.up, 90);
    }

    public void RightRotate()
    {
        Rotate.Instance.RotateObject(transform.gameObject, Vector3.down, 90);
    }

    public void ScaleUp()
    {
        Scale.Instance.ScaleObject(transform.gameObject, Vector3.one * 0.1f);
    }

    public void ScaleDown()
    {
        Scale.Instance.ScaleObject(transform.gameObject, Vector3.one * -0.1f);
    }

    public void MoveForward()
    {
        Move.Instance.MoveObject(transform.gameObject, Vector3.forward);
    }

    public void MoveBackward()
    {
        Move.Instance.MoveObject(transform.gameObject, Vector3.back);
    }
}
