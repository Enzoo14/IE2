Public Class Form
    Dim operacion_ As String

    Dim MiTurnos As New Turnos


    Public Property operacion() As String

        Get
            Return operacion_

        End Get

        Set(ByVal value As String)

            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    
   
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        MiTurnos.Id = (TextBox1.Text)
        MiTurnos.Fecha = (TextBox2.Text)
        MiTurnos.Asignatura = (TextBox3.Text)
        MiTurnos.Docente = ComboBox1.SelectedIndex()
        MiTurnos.Vocal1 = ComboBox2.SelectedIndex()
        MiTurnos.Vocal2 = ComboBox3.selectedIndex()
        Select Case operacion_
            Case "Agregar"

                lst.Add(MiTurnos)
            Case "Eliminar"
                lst.RemoveAt(indice_)
            Case "Modificar"
                lst.Item(indice_) = MiTurnos

                FormGrid.DataGridView1.Refresh()

        End Select
        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) And Char.IsControl(e.KeyChar) Then

            e.Handled = False

            Exit Sub

        End If
        Dim pos As Integer = TextBox2.SelectionStart
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = False
        End If
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) And Char.IsControl(e.KeyChar) Then

            e.Handled = False

            Exit Sub
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

   
   
End Class


