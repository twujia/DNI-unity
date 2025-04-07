using UnityEngine;

public class capsuleScript : MonoBehaviour
{

    [SerializeField]
    private Color changeColorTo = Color.white; // SerializeField exposes 'changeColorTo' in the editor.
    
    private void OnCollisionEnter()
    {
        // Get the material used by this game object's 'Renderer'.
        var material = GetComponent<Renderer>().material;

        // Now able to change color of the material.
        material.color = this.changeColorTo;
    }
}
