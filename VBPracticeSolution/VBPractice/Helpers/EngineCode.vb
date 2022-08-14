

Public Class EngineCode


    Public Function AddColumnas(ByVal dgv As DataGridView) As DataGridView


        dgv.Columns.Add("Asignado", "Asignado")
        dgv.Columns.Add("FechaAsignacionRQ", "FechaAsignacionRQ")
        dgv.Columns.Add("AsignadoPor", "AsignadoPor")
        dgv.Columns.Add("StatusRQ", "StatusRQ")
        dgv.Columns.Add("FechaSolicitudCotizacion", "FechaSolicitudCotizacion")
        dgv.Columns.Add("Existe", "Existe")
        dgv.Columns.Add("Columna", "Columna")

        Return dgv

    End Function

    Public Function RemoveColumnas(ByVal dgv As DataGridView) As DataGridView


        dgv.Columns.Remove("Asignado")
        dgv.Columns.Remove("FechaAsignacionRQ")
        dgv.Columns.Remove("AsignadoPor")
        dgv.Columns.Remove("StatusRQ")
        dgv.Columns.Remove("FechaSolicitudCotizacion")
        dgv.Columns.Remove("Existe")
        dgv.Columns.Remove("Columna")

        Return dgv

    End Function

End Class
