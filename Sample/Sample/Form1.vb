
Imports TheEcodes.HelperFunctions
Imports TheEcodes

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New List(Of String)
        x = TheEcodes.HelperFunctions.EnumerateEcodesToList
        For Each ec In x
            ListBox1.Items.Add(ec)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim eci As New EcodeInformation(HelperFunctions.ConvertStringToEcode(ListBox1.SelectedItem))
        RichTextBox1.Text = eci.AdvertName & vbCrLf & eci.EquivalentName & vbCrLf & eci.AbstractInformation & vbCrLf & eci.CodeIntegrity
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
