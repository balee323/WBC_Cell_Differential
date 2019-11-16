Friend Interface IDataRepo

    Sub SaveUserData(cellSettingsJson As String)

    Function LoadUserSettings() As String

    Function LoadReports(searchFiler As SearchFilter) As List(Of String)

    Sub SaveReport(report As Report, reportDetailsJson As String, progressBar As ProgressBar, saveComplete As Label)



End Interface
