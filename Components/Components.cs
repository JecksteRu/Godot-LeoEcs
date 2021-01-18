using Godot;
using System;








public struct PlayerInputComponent
{
    public Vector2 MoveDirection;
}

public struct MoveableComponent
{
    public KinematicBody2D Body;
    public float Speed;
    public bool IsMoving;
}