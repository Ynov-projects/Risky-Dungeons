using UnityEngine;
using UnityEngine.Events;

public class TriggerableInteraction : MonoBehaviour
{
    [SerializeField] UnityEvent actions;

    private bool isInTrigger;

    private void Update()
    {
        if(isInTrigger /* && InputAction.action(interactionAction) */)
            actions.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            isInTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            isInTrigger = false;
    }

    public void openPopUp(GameObject popup)
    {
        popup.SetActive(true);
    }
}
