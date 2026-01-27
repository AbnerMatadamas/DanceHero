using UnityEngine;

public class LaneManager : MonoBehaviour
{
    [SerializeField]
    private Lane[] lanes;
    private Lane GetLane(int index)
    {
        return lanes[index];
    }
}
