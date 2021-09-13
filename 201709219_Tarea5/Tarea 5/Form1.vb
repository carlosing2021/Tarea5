Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If indice < 9 Then
            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem
            subtotal_a_pagar(indice) = calcularSubtotal(vfuncion(indice), vcine(indice))
            vdescuento1(indice) = subtotal_a_pagar(indice) + calculoDescuento1(vfuncion(indice), vcine(indice))

            Funcion.Items.Add(vfuncion(indice))
            Cine.Items.Add(vcine(indice))
            SubTotal.Items.Add(subtotal_a_pagar(indice))
            Descuento1.Items.Add(vdescuento1(indice))
        ElseIf indice >= 9 Then

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar_entradas()
    End Sub
End Class
