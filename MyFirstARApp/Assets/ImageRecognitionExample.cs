using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class NewBehaviourScript : MonoBehaviour
{

    private ARTrackedImageManger _arTrackedImageManger;

    private void Awake()
    {
        _arTrackedImageManger = FindObjectOfType<ARTrackedImageManger>();
    }

    public void OnEnable()
    {
        _arTrackedImageManger.trackedImagesChanged += OnImageChanged;
    }

       public void OnDisable()
    {
        _arTrackedImageManger.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
