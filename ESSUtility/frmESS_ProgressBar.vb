Public Class frmESS_ProgressBar
    Public Overloads Sub Show(ByVal master As Integer, ByVal slave As Integer, Optional ByVal title As String = "Tiến trình thực hiện")
        Me.Text = title
        prgMaster.Value = master
        prgSlave.Value = slave
        Me.Show()
        Application.DoEvents()
    End Sub

    Public Property Master_Max() As Integer
        Get
            Return prgMaster.Maximum
        End Get
        Set(ByVal Value As Integer)
            prgMaster.Maximum = Value
        End Set
    End Property

    Public Property Slave_Max() As Integer
        Get
            Return prgSlave.Maximum
        End Get
        Set(ByVal Value As Integer)
            prgSlave.Maximum = Value
        End Set
    End Property
End Class