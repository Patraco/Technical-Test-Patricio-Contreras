using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{
    public Animator AnimatorController;
    public bool BirdIsFlying;
    public bool itsGonnaMove;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (itsGonnaMove)
            {
                switch (BirdIsFlying)
                {
                    case true:
                        AnimatorController.SetBool("GoDown", true);
                        AnimatorController.SetBool("GoUp", false);
                        BirdIsFlying = false;
                        break;
                    case false:
                        AnimatorController.SetBool("GoDown", false);
                        AnimatorController.SetBool("GoUp", true);
                        BirdIsFlying = true;
                        break;
                }                
            }            
        }
    }
    [SerializeField]
    private  Transform cube;

    [SerializeField] 
    private Transform plane;

    // Implement logic here to move cube in an arc
    //from each starting position to the center of
    //the plane when press space bar, or back if it
    //is already there.
}