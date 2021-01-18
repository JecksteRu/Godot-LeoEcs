using Godot;
using System;

public class EcsTreeHandler : Node
{
    private static EcsTreeHandler Instance;
    private EcsTreeHandler()
    {
        Instance = this;
    }

    public static void AddToTree(Node node) => Instance.GetTree().Root.CallDeferred("add_child", node);
}
