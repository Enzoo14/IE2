Public Class FormGrid


    Private Sub FormGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
        'For Each item As String In ComboBox1.items
        '    ComboBox2.Items.Add(item)
        '    ComboBox3.Items.Add(item)
        'Next
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        Form.operacion = "Agregar"
        Form.Text = "Agrega"
        Form.ShowDialog()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Form.operacion = "Modificar"
        Form.Text = "Modificar"
        Form.ShowDialog()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Form.operacion = "Eliminar"
        Form.Text = "Eliminar"
        Form.Show()
        Form.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form.Show()
    End Sub
    Private Sub llenarform()
        Form.id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Form.Fecha.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form.Asignatura.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form.Docente.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form.Vocal1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form.Vocal2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
End Class