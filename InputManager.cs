using System.Runtime.InteropServices;
using UnityEngine;

public static class InputManager
{
    private static EnumPlayerInputs enumControls;

    public static void initEnumController(EnumerationController controller)
    {
        enumControls = new EnumPlayerInputs();

        enumControls.Main.Enable();

        enumControls.Main.Action.performed += ctx =>
        {
            controller.UseAction();
        };

        enumControls.Main.Movement.performed += ctx =>
        {
            controller.MovePlayer(ctx.ReadValue<Vector3>());
        };

        enumControls.Main.RemoveEnumAction.performed += ctx =>
        {
            controller.ChangeActionState(EnumActionState.None);
        };

        enumControls.Main.ShorterEnumAction.performed += ctx =>
        {
            controller.ChangeActionState(EnumActionState.Shorter);
        };

        enumControls.Main.TallerEnumAction.performed += ctx =>
        {
            controller.ChangeActionState(EnumActionState.Taller);
        };

        enumControls.Main.MoveEnumAction.performed += ctx =>
        {
            controller.ChangeActionState(EnumActionState.Movement);
        };

        enumControls.Main.ColorChangeInputAction.performed += ctx =>
        {
            controller.ChangeActionState(EnumActionState.ColorChange);
        };
    }
}
