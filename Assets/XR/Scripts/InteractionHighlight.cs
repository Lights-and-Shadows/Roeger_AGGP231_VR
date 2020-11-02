using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionHighlight : MonoBehaviour
{
    public Material mat_Hover = null;
    public Material mat_Hightlight = null;

    private Material mat_Original = null;
    private MeshRenderer meshRenderer = null;
    private XRGrabInteractable grabbableObj = null;

    private void Awake()
    {
        mat_Original = GetComponent<Material>();
        meshRenderer = GetComponent<MeshRenderer>();
        grabbableObj = GetComponent<XRGrabInteractable>();

        grabbableObj.onActivate.AddListener(SetHighlight);
        grabbableObj.onDeactivate.AddListener(SetOriginal);
        grabbableObj.onHoverEnter.AddListener(SetHover);
    }

    private void OnDestroy()
    {
        grabbableObj.onActivate.RemoveListener(SetHighlight);
        grabbableObj.onDeactivate.RemoveListener(SetOriginal);
        grabbableObj.onDeactivate.RemoveListener(SetHover);
    }

    private void SetHover(XRBaseInteractor arg0)
    {
        meshRenderer.material = mat_Hover;
    }

    private void SetOriginal(XRBaseInteractor arg0)
    {
        meshRenderer.material = mat_Original;
    }

    private void SetHighlight(XRBaseInteractor arg0)
    {
        meshRenderer.material = mat_Hightlight;
    }

}
