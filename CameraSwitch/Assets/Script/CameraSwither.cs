using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwither : MonoBehaviour
{
    [SerializeField] private List<Camera> cameras;

    void Start()
    {
        ActiveCamera(0);
    }

    void Update()
    {
        var alpha1EnumInteger = (int)KeyCode.Alpha1;

        for (int i = 0; i < cameras.Count; i++)
        {
            var keyCodeEnumInteger = alpha1EnumInteger + i;
            if (Input.GetKeyDown((KeyCode)keyCodeEnumInteger))
            {
                ActiveCamera(i);
            }
        }
    }

    void ActiveCamera(int activeCameraIndex)
    {
        for (var i = 0; i < cameras.Count; i++)
        {
            cameras[i].gameObject.SetActive(i == activeCameraIndex);
        }
    }
}