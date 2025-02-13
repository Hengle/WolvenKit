﻿using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questTeleportPuppetNodeDefinitionWrapper : questAICommandNodeBaseWrapper<questTeleportPuppetNodeDefinition>
{
    public questTeleportPuppetNodeDefinitionWrapper(questTeleportPuppetNodeDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}