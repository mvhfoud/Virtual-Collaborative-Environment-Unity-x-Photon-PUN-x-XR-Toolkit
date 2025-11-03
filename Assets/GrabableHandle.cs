using UnityEngine;
namespace RVC {

public class GrabableHandle : Grabable
{
    // Override the LocalRelease method
    public override void LocalRelease()
    {
          if (caught)
    {
        Debug.Log("LocalRelease called");
        base.LocalRelease();
        Debug.Log("Resetting local position and rotation");
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
    }
    
}
}