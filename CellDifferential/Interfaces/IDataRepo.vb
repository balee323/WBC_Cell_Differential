Friend Interface IDataRepo

    Sub SaveUserData(cellSettingsJson As String)

    Function LoadUserSettings() As String

    Function LoadReports() As String

    Sub SaveReport(reportHeader As ReportHeader, reportDetailsJson As String, progressBar As ProgressBar, saveComplete As Label)



End Interface
