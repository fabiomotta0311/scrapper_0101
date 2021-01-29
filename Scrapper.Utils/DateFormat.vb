Public Class DateFormat
    Public Shared Function DateSap(dt As Date) As String
        Dim d As String
        Dim m As String
        Dim y As Integer

        Dim strDate As String

        d = dt.Day().ToString()
        m = dt.Month().ToString()
        y = dt.Year()

        If dt.Day < 10 Then d = "0" & d
        If dt.Month < 10 Then m = "0" & m

        strDate = String.Format("{0}.{1}.{2}", d, m, y)

        Return strDate
    End Function

    Public Shared Function DateSub(dt As Date, Optional intDay As Integer = 0, Optional intMonth As Integer = 0, Optional intYear As Integer = 0) As Date
        DateSub = New Date(dt.Year - intYear, dt.Month - intMonth, dt.Day - intDay)
    End Function
End Class
