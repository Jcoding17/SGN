Imports SGN.DAL
Imports SGN.Entity

Public Class DashBoardBLL
    Public Shared Sub DashBoard(dash As DashboardEntity)
        DashBoardDAL.Dashboard(dash)
        DashBoardDAL.ArtPreferidos(dash)
        DashBoardDAL.ArtPorCategoria(dash)
    End Sub

End Class
