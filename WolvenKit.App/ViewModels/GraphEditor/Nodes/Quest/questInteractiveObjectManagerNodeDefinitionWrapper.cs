﻿using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questInteractiveObjectManagerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questInteractiveObjectManagerNodeDefinition>
{
    public questInteractiveObjectManagerNodeDefinitionWrapper(questInteractiveObjectManagerNodeDefinition questDisableableNodeDefinition) : base(questDisableableNodeDefinition)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}