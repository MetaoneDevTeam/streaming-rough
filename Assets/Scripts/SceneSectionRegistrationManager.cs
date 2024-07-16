using UnityEngine;

public class SceneSectionRegistrationManager : MonoBehaviour
{
    public int _idCounter = 0;

    public int RequestRegistration()
    {
        _idCounter++;
        return _idCounter;
    }
}
