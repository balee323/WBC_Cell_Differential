Public Interface ISettings

    Sub SavePeripheralKeyBindings()
    Sub SaveBoneMarrowKeyBindings()
    Sub SavePeripheralCountingChannelNames()
    Sub SaveBoneMarrowCountingChannelNames()
    Sub LoadPeripheralKeyBindings()
    Sub LoadBoneMarrowKeyBindings()
    Sub LoadPeripheralCountingChannelNames()
    Sub LoadBoneMarrowCountingChannelNames()
    Structure RegistryKeyName
        Public Shared PeriheralKeys As String = "KeyMappings1"
        Public Shared BoneMarrowKeys As String = "KeyMappings2"
        Public Shared PeripheralChannels As String = "ChannelNames1"
        Public Shared BoneMarrowChannels As String = "ChannelNames2"
    End Structure


End Interface
