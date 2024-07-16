using System;
using UnityEngine;
using Unity.Mathematics;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    [SerializeField]
    private Transform _cameraTransform;

    public float3 _cameraForward;
    public float3 _cameraRight;

    public float _cYaw;
    public float _cRoll;
    //public float _cYaw;
    
    [SerializeField]
    private float[] _yawLimit;
 [SerializeField]
    private float _yawSensitivity = 70f;
    [SerializeField]
    private Transform _cameraYawTransform;
    private Vector3 _yawTemp = new Vector3();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        _cameraForward = _cameraTransform.forward;
        _cameraForward.y = 0f;
        _cameraForward = math.normalize(_cameraForward);
        
        _cameraRight = _cameraTransform.right;
        _cameraRight = math.cross(_cameraForward, math.up());
        
    }
    
    void LateUpdate()
    {
        // roll calculation/
        _cRoll += InputManager.instance.rHorizontal * Time.deltaTime * 8f;
        
        if (_cRoll < 0f) _cRoll += 360f;
        if (_cRoll > 360f) _cRoll -= 360f;
        
        // yaw calculation (unfinished)

        _cYaw += InputManager.instance.rVertical * Time.deltaTime * 8f;
        _cYaw = math.clamp(_cYaw, _yawLimit[0], _yawLimit[1]);

        // look into this --
        transform.rotation = quaternion.Euler(new float3(0f, _cRoll, 0f), math.RotationOrder.Default);
        
        //_yawTemp.x += InputManager.instance.rLerped.y * Time.deltaTime * _yawSensitivity;
        //_yawTemp.x = Mathf.Clamp(_yawTemp.x, _yawLimit[0], _yawLimit[1]);
        //_cameraYawTransform.localEulerAngles = _yawTemp;
        
        
    }
}
