Friend Interface IDataRepo

    Sub SaveUserData(cellSettingsJson As String)

    Function LoadUserSettings(userInfo As UserInfo) As Boolean


End Interface
