Friend Interface IDataRepo

    Sub SaveUserData(cellSettingsJson As String)

    Function LoadUserSettings() As String

    Function LoadReports() As String

    Sub SaveReports(reportDetailsJson As String, progressBar As ProgressBar, saveComplete As Label)



End Interface
