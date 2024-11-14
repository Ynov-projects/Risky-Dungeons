using UnityEngine;

public class DescriptorItemScript : MonoBehaviour
{
    private string itemName;
    private int itemId;

    public void Entering()
    {
        UIManager.Instance.changeDescriptorItemInfo(itemName, itemId);
    }

    public void SetupInfo(string _itemName, int _itemId)
    {
        itemName = _itemName;
        itemId = _itemId;
    }
}
