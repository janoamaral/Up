Public Class frmMain



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim hostName As String = InputBox("Host o IP a monitorear", "Ingrese el host")

        If hostName.Length > 0 Then

            Dim test As New TestEngine
            test.Host = hostName
            test.Timeout = numTimeout.Value * 1000
            test.TrySSL = chkHTTPS.Checked


            Dim lst As New ListViewItem
            lst.Text = test.Host
            lst.SubItems.Add("N/A")
            lst.SubItems.Add("N/A")
            lst.SubItems.Add(0)
            lst.SubItems.Add(0)


            lst.Tag = test

            lstHosts.Items.Add(lst)
        End If


    End Sub

    Private Sub globalTimer_Tick(sender As Object, e As EventArgs) Handles globalTimer.Tick
        lblStatus.Text = "Testeando, espere por favor..."
        globalTimer.Enabled = False
        Dim lstTest As ListViewItem


        For Each lstTest In lstHosts.Items
            Dim test As TestEngine
            test = lstTest.Tag

            Dim lstTestResult As New ListViewItem
            lstTestResult.Text = lstHistory.Items.Count
            lstTestResult.SubItems.Add(test.Host)

            test.Test()


            If test.LastTest.StatusHTTP Then
                lstTestResult.SubItems.Add("OK")
                lstTest.SubItems(1).Text = "OK"
            Else
                lstTestResult.SubItems.Add("FALLO")
                lstTest.SubItems(1).Text = "FALLO"
            End If

            If test.LastTest.StatusICMP Then
                lstTestResult.SubItems.Add("OK")
                lstTest.SubItems(2).Text = "OK"
            Else
                lstTestResult.SubItems.Add("FALLO")
                lstTest.SubItems(2).Text = "FALLO"
            End If

            lstTest.SubItems(3).Text = test.PruebasRealizadas
            lstTest.SubItems(4).Text = test.PruebasFallidas
            lstTest.Tag = test



            lstTestResult.SubItems.Add(test.LastTest.Timestamp)
            test.SaveLastHistoryEntry(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/" & test.GetSanitizedHost & ".csv")
            lstHistory.Items.Add(lstTestResult)
        Next
        Dim tmpUltimaActualizacion As Date
        tmpUltimaActualizacion = Now.AddSeconds(numIntervalo.Value)
        lblStatus.Text = "Próxima actualización " & tmpUltimaActualizacion.ToShortTimeString
        globalTimer.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim test As New TestEngine
        test = lstHosts.Items(0).Tag
        test.SaveHistoryToFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "/" & test.GetSanitizedHost & ".csv")
    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        SplitContainer1.Panel1Collapsed = Not SplitContainer1.Panel1Collapsed
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        globalTimer.Interval = numIntervalo.Value * 1000
        Dim lstTest As ListViewItem
        For Each lstTest In lstHosts.Items
            lstTest.Tag.timeout = numTimeout.Value * 1000
            lstTest.Tag.TrySSL = chkHTTPS.Checked
        Next

        My.Settings.intervalo = numIntervalo.Value
        My.Settings.timeout = numTimeout.Value
        My.Settings.tryssl = chkHTTPS.Checked
        My.Settings.Save()

        lblStatus.Text = "Opciones guardadas"


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If lstHosts.SelectedItems.Count > 0 Then
            Dim hostName As String = InputBox("Host o IP a monitorear", "Ingrese el host", lstHosts.SelectedItems(0).Text)

            If hostName.Length > 0 Then
                lstHosts.SelectedItems(0).Text = hostName
                lstHosts.SelectedItems(0).Tag.Host = hostName
            End If
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If lstHosts.SelectedItems.Count > 0 Then
            lstHosts.SelectedItems(0).Remove()
            lstHosts.Refresh()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        numIntervalo.Value = My.Settings.intervalo
        numTimeout.Value = My.Settings.timeout
        chkHTTPS.Checked = My.Settings.tryssl
        globalTimer.Interval = My.Settings.intervalo * 1000
    End Sub
End Class
