using Unity.Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private CinemachineCamera overviewCamera;
    [SerializeField]
    private CinemachineCamera orbitalCamera;

    private bool isOverviewCameraActive = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOverviewCameraActive = !isOverviewCameraActive;
            if (isOverviewCameraActive)
            {
                overviewCamera.Priority = 1;
                orbitalCamera.Priority = 0;
            }
            else
            {
                overviewCamera.Priority = 0;
                orbitalCamera.Priority = 1;
            }
        }
    }
}
