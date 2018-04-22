using UnityEngine;

public class SpiritController : MonoBehaviour
{
    private SpiritsController _spiritsController;
    
    void Init(SpiritsController spiritsController)
    {
        _spiritsController = spiritsController;
    }
    
    private void OnDestroy()
    {
        if (_spiritsController != null)
        {
            _spiritsController.SpiritDestoyed(gameObject);
        }
    }
}
