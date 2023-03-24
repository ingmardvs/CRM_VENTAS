Public Class FmSeguimientoGTES

    Dim Conexion As Conexion_Dt = New Conexion_Dt
    Dim Conexion2 As Conexion_Dr = New Conexion_Dr
    Dim proec, etac, ege, eacc, epm As String
    Dim info As Boolean
    Dim feccita As Date
    Private Sub FmSeguimiento_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dtpcita.Value = DateTime.Now
        Me.Text = "Nombre del Asesor - Seguimiento de Prospectos - " & DateTime.Now
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Mostrar_Datos()         'carga la informacion al datagrid
        ColoreaAct()
        DvgProsperto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DvgProsperto.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DvgProsperto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DvgProsperto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Conexion2.LlenarCombo("SELECT RTRIM(VEND_NOMBRE) + ' ' + RTRIM(VEND_PATERNO) + ' ' +VEND_MATERNO+' -'+ convert(varchar(4),VEND_ID) AS NOMBRE FROM CRM_VENDEDORES ORDER BY VEND_NOMBRE ASC", cmbvendedor)
    End Sub

    Private Sub DvgProsperto_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DvgProsperto.CellContentDoubleClick
        ColoreaAct()
        If e.RowIndex >= 0 Then
            ColoreaAct()
            Dim Dgv_Buscar As DataGridViewRow = DvgProsperto.Rows(e.RowIndex)
            Id_Bus = Dgv_Buscar.Cells("PRO_ID").Value.ToString

            If (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "NOMBRE" Then
                Activar = 1
                FmActProsGral.Text = "ACTUALIZACION DE PROSPECTOS"
                FmActProsGral.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "VEHICULO" Then
                Activar = 1
                FmAltaPros.Text = "ACTUALIZACION DE UNIDADES"
                FmAltaPros.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "CITA" Then
                FmCitasHist.Text = "HISTORIAL DE CITAS DEL PROSPECTO : " & (Dgv_Buscar.Cells("NOMBRE").Value.ToString)
                FmCitasHist.ShowDialog()


            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "VEND" Then


            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "PM" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "PE" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                FmPE.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "GE" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
               MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ACC" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "FI" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "TAC" Then
                Activar = 1
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "CMP" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "CRE" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                FmEC.ShowDialog()
                MsgBox(DvgProsperto.CurrentCell.ToString)

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ENG" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
               MsgBox(DvgProsperto.CurrentCell.ToString)
                FmENG.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "FAC" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
               MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoAut()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "PA" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ATN" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoDatos()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ENT" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoAut()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "AUT" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoFAC()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "COMPRO" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ToString)
                VerificoFAC()

            Else
                'MsgBox(DvgProsperto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                'MsgBox(DvgProsperto.CurrentCell.OwningColumn.DataPropertyName)
            End If

        End If

    End Sub



    Public Sub Mostrar_Datos()
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE ,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" &
        "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO ,ISNULL((SELECT TOP(1)CIT_FECCITA  FROM CRM_CITAS where CIT_IDPROS = PRO_ID ORDER BY CIT_FECCITA DESC),PRO_FECALTA) AS CITA," &
        "isnull(ACT_ESTATUSATN,'') as ATN,isnull(ACT_ESTATUSPM,'') as PM,isnull(ACT_ESTATUSGE,'') as GE,isnull(ACC_ESTATUS,'') as ACC,isnull(ACT_ESTATUSFI,'') as FI,isnull(TAC_ESTATUS,'') as TAC," &
        "isnull(RTRIM(COM_MARCA1),'') + ' ' +isnull(RTRIM(COM_MARCA2),'') + ' ' + isnull(RTRIM(COM_MARCA3),'') as CMP,isnull(ACT_ESTATUSPE,'') as PE,isnull(ACT_ESTATUSPA,'') as PA,isnull(EC_ESTATUS,'') as CRE,isnull(ENG_ESTATUS,'') as ENG,isnull(ACT_ESTATUSFAC,'') as FAC,isnull(ACT_ESTATUSENT,'') as ENT, isnull(ACT_ESTATUSAUT,'') as AUT ,isnull(ACT_ESTATUSCOMPRA,'') as COMPRO" &
        " From CRM_PROSPECTOS as PROS LEFT JOIN CRM_VENDEDORES AS VEND ON PROS.PRO_IDvend = VEND.VEND_ID LEFT JOIN CRM_TAC ON PROS.PRO_ID = CRM_TAC.TAC_IDPROS left join CRM_ACTIVIDADES AS ACT ON PROS.PRO_ID = ACT.ACT_IDPROS left join CRM_COMPETIDOR AS COMP ON PROS.PRO_ID = COMP.COM_IDPROS left join CRM_ACCESORIOS AS ACC ON PROS.PRO_ID = ACC.ACC_PROSID LEFT JOIN CRM_PE AS PE ON PROS.PRO_ID = PE.PE_IDPROS LEFT JOIN CRM_EC AS EC ON PROS.PRO_ID = EC.EC_IDPROS LEFT JOIN CRM_ENG AS ENG ON PROS.PRO_ID = ENG.ENG_IDPROS"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
        Limpiar()
    End Sub

    Public Sub Buscar_Datos()
        If txtmaterno.Text <> "" Then txtmaterno.Text = "%" + txtmaterno.Text + "%"
        If txtpaterno.Text <> "" Then txtpaterno.Text = "%" + txtpaterno.Text + "%"
        If txtnombre.Text <> "" Then txtnombre.Text = "%" + txtnombre.Text + "%"
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE ,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" &
        "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO ,ISNULL((SELECT TOP(1)CIT_FECCITA  FROM CRM_CITAS where CIT_IDPROS = PRO_ID ORDER BY CIT_FECCITA DESC),PRO_FECALTA) AS CITA," &
        "isnull(ACT_ESTATUSATN,'') as ATN,isnull(ACT_ESTATUSPM,'') as PM,isnull(ACT_ESTATUSGE,'') as GE,isnull(ACC_ESTATUS,'') as ACC,isnull(ACT_ESTATUSFI,'') as FI,isnull(TAC_ESTATUS,'') as TAC," &
        "isnull(RTRIM(COM_MARCA1),'') + ' ' +isnull(RTRIM(COM_MARCA2),'') + ' ' + isnull(RTRIM(COM_MARCA3),'') as CMP,isnull(ACT_ESTATUSPE,'') as PE,isnull(ACT_ESTATUSPA,'') as PA,isnull(EC_ESTATUS,'') as CRE,isnull(ENG_ESTATUS,'') as ENG,isnull(ACT_ESTATUSFAC,'') as FAC,isnull(ACT_ESTATUSENT,'') as ENT, isnull(ACT_ESTATUSAUT,'') as AUT ,isnull(ACT_ESTATUSCOMPRA,'') as COMPRO" &
        " From CRM_PROSPECTOS LEFT JOIN CRM_TAC ON CRM_PROSPECTOS.PRO_ID = CRM_TAC.TAC_IDPROS left join CRM_ACTIVIDADES ON CRM_PROSPECTOS.PRO_ID = CRM_ACTIVIDADES.ACT_IDPROS left join CRM_COMPETIDOR ON CRM_PROSPECTOS.PRO_ID = CRM_COMPETIDOR.COM_IDPROS LEFT JOIN CRM_VENDEDORES ON CRM_PROSPECTOS.PRO_IDVEND = CRM_VENDEDORES.VEND_ID left join CRM_ACCESORIOS AS ACC ON PROS.PRO_ID = ACC.ACC_PROSID LEFT JOIN CRM_PE AS ENG ON PROS.PRO_ID = ENG.PE_IDPROS LEFT JOIN CRM_EC AS EC ON PROS.PRO_ID = EC.EC_IDPROS WHERE PRO_NOMBRE like '" + txtnombre.Text + "' or PRO_PATERNO like '" + txtpaterno.Text + "' OR PRO_MATERNO like '" + txtmaterno.Text + "'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
        Limpiar()
    End Sub

    Public Sub COLOR_CELDAS()
        For A As Integer = 0 To DvgProsperto.RowCount() - 1 Step 1
            For B As Integer = 5 To 19 Step 1
                If B = 5 Then
                    'Actividad Atención
                    If DvgProsperto.Rows(A).Cells(B).Value = "ACUERDO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "DESACUERDO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                    End If
                ElseIf B = 11 Then
                    If (DvgProsperto.Rows(A).Cells(6).Value <> "") Then
                        If DvgProsperto.Rows(A).Cells(B).Value <> "  " Then
                            DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                        Else
                            DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                        End If
                    End If
                ElseIf B = 15 Then
                    If DvgProsperto.Rows(A).Cells(B).Value = "ENGANCHE" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "APARTADO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.LightYellow
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "NO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                    End If
                ElseIf B = 14 Then
                    If DvgProsperto.Rows(A).Cells(B).Value = "AUTORIZADA" Or DvgProsperto.Rows(A).Cells(B).Value = "SI" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "CONDICIONADA" Or DvgProsperto.Rows(A).Cells(B).Value = "PENDIENTE" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.LightYellow
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "NO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                    End If
                Else
                    If DvgProsperto.Rows(A).Cells(B).Value = "SI" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "PENDIENTE" Or DvgProsperto.Rows(A).Cells(B).Value = "NO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "SI,SI" Or DvgProsperto.Rows(A).Cells(B).Value = "SI,NO" Or DvgProsperto.Rows(A).Cells(B).Value = "NO,NO" Or DvgProsperto.Rows(A).Cells(B).Value = "NO,SI" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.LightBlue
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub DvgProsperto_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DvgProsperto.Sorted
        COLOR_CELDAS()
    End Sub

    Public Sub VerificoFAC()
        Conexion2.Consultar("SELECT isnull(ACT_ESTATUSPE,''),isnull(PE_ESTATUS,''),isnull(ACT_ESTATUSPA,'') FROM CRM_ACTIVIDADES LEFT JOIN CRM_PE AS ENG ON CRM_ACTIVIDADES.ACT_IDPROS = ENG.PE_IDPROS WHERE ACT_IDPROS ='" & Id_Bus & "'")
        If Conexion2.dr.HasRows Then
            Conexion2.dr.Read()
            If (Conexion2.dr.GetString(0) = "SI,SI" And Conexion2.dr.GetString(2) = "SI,SI") Then
                Conexion2.dr.Close()
                Conexion2.desconectarse()
                FmActividades.ShowDialog()
            ElseIf Conexion2.dr.GetString(1) = "SI" Then
                Conexion2.dr.Close()
                Conexion2.desconectarse()
                FmActividades.ShowDialog()
            Else
                MsgBox("No cumple con los requisitos para facturar.")
            End If
        Else
            MsgBox("No cumple con los requisitos para facturar.")
        End If
        Conexion2.dr.Close()
        Conexion2.desconectarse()
    End Sub

    Public Sub VerificoAut()
        Conexion2.Consultar("SELECT isnull(ACT_ESTATUSaut,'') FROM CRM_ACTIVIDADES WHERE ACT_IDPROS ='" & Id_Bus & "'")
        If Conexion2.dr.HasRows Then
            Conexion2.dr.Read()
            If (Conexion2.dr.GetString(0) = "SI") Then FmActividades.ShowDialog() Else MsgBox("El gerente aún no ha autorizado esta unidad.")
            Conexion2.dr.Close()
            Conexion2.desconectarse()
        End If
        Conexion2.dr.Close()
        Conexion2.desconectarse()
    End Sub

    ' Public Sub VerificoAntesPe()
    '   Conexion2.Consultar("SELECT isnull(TAC_ESTATUS,'') as TAC,isnull(ACT_ESTATUSGE,'') as GE,isnull(ACC_ESTATUS,'') as ACC,isnull(ACT_ESTATUSPM,'') as PM FROM CRM_TAC LEFT JOIN CRM_ACTIVIDADES ON CRM_TAC.TAC_IDPROS = CRM_ACTIVIDADES.ACT_IDPROS left join CRM_ACCESORIOS AS ACC ON CRM_ACTIVIDADES.ACT_IDPROS = ACC.ACC_PROSID where CRM_TAC.TAC_IDPROS ='" & Id_Bus & "'")
    '  If Conexion2.dr.HasRows Then
    '     Conexion2.dr.Read()
    '    If (Conexion2.dr.GetString(0) = "" Or Conexion2.dr.GetString(0) = "PENDIENTE" Or Conexion2.dr.GetString(1) = "" Or Conexion2.dr.GetString(1) = "PENDIENTE" Or Conexion2.dr.GetString(2) = "" Or Conexion2.dr.GetString(2) = "PENDIENTE" Or Conexion2.dr.GetString(3) = "" Or Conexion2.dr.GetString(3) = "PENDIENTE") Then
    '       MsgBox("Las actividades anteriores a la propuesta economica aún no se han llevado a cabo o estan pendientes.")
    '  Else
    '      Conexion2.dr.Close()
    '      Conexion2.desconectarse()
    '     If (Actividad = "CMP") Then
    '        FmCompetidor.ShowDialog()
    '   ElseIf (Actividad = "ENG") Then
    '      FmPE.ShowDialog()
    ' ElseIf (Actividad = "ACC") Then
    '    FmAcc.ShowDialog()
    'ElseIf (Actividad = "CRE") Then
    '    FmEC.ShowDialog()
    'ElseIf (Actividad = "PE") Then
    '    FmPE.ShowDialog()
    'Else
    '   FmActividades.ShowDialog()
    'End If
    'End If
    'Else
    '   MsgBox("Las actividades anteriores a la propuesta economica aún no se han llevado a cabo o estan pendientes.")
    'End If
    'Conexion2.dr.Close()
    'Conexion2.desconectarse()
    'End Sub

    Public Sub ColoreaAct()
        'Dim i As Integer
        ' For i = 0 To DvgProsperto.RowCount() - 1 Step +1
        'If (DvgProsperto.Rows(i).Cells(6).Value = "SI,SI" And DvgProsperto.Rows(i).Cells(7).Value = "SI,SI" And DvgProsperto.Rows(i).Cells(14).Value = "SI,SI") Then
        'DvgProsperto.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
        ' End If
        'Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ColoreaAct()
        Mostrar_Datos()
        Timer1.Stop()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Buscar_Datos()
    End Sub

    Public Sub VerificoDatos()
        Conexion2.Consultar("select PRO_CALLE,PRO_COLONIA,PRO_CP,PRO_CIUDAD,PRO_TELCEL,PRO_CORREO,PRO_FORCON,PRO_HRINI,PRO_HRFIN,PRO_CLI1,PRO_MOD1,PRO_PAQ1,PRO_STATUS1 from CRM_PROSPECTOS where PRO_ID = '" & Id_Bus & "' AND PRO_CALLE <> '' AND PRO_COLONIA <> '' AND PRO_CP <> '' AND PRO_CIUDAD <> '' AND PRO_TELCEL <> '' AND PRO_CORREO <> '' AND PRO_FORCON <> '' AND PRO_HRINI <> '' AND PRO_HRFIN <> '' AND PRO_CLI1 <> '' AND PRO_MOD1 <>'' AND PRO_PAQ1 <> '' AND PRO_STATUS1 = '1'")
        If (Conexion2.dr.HasRows) Then
            Conexion2.dr.Close()
            Conexion2.desconectarse()
            If (Actividad = "CMP") Then
                FmCompetidor.ShowDialog()
            ElseIf (Actividad = "ENG") Then
                FmPE.ShowDialog()
            ElseIf (Actividad = "ACC") Then
                FmAcc.ShowDialog()
            ElseIf (Actividad = "TAC") Then
                FmTAC.ShowDialog()
            Else
                FmActividades.ShowDialog()
            End If
        Else
            MsgBox("Aún no has llenado la información obligatoria del prospecto.")
        End If
        Conexion2.dr.Close()
        Conexion2.desconectarse()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncanc.Click, btncancvend.Click, btncanccita.Click
        Mostrar_Datos()
    End Sub

    Private Sub btnbuscavend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscavend.Click
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE ,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" &
        "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO ,ISNULL((SELECT TOP(1)CIT_FECCITA  FROM CRM_CITAS where CIT_IDPROS = PRO_ID ORDER BY CIT_FECCITA DESC),PRO_FECALTA) AS CITA," &
        "isnull(ACT_ESTATUSATN,'') as ATN,isnull(ACT_ESTATUSPM,'') as PM,isnull(ACT_ESTATUSGE,'') as GE,isnull(ACC_ESTATUS,'') as ACC,isnull(ACT_ESTATUSFI,'') as FI,isnull(TAC_ESTATUS,'') as TAC," &
        "isnull(RTRIM(COM_MARCA1),'') + ' ' +isnull(RTRIM(COM_MARCA2),'') + ' ' + isnull(RTRIM(COM_MARCA3),'') as CMP,isnull(ACT_ESTATUSPE,'') as PE,isnull(ACT_ESTATUSPA,'') as PA,isnull(EC_ESTATUS,'') as CRE,isnull(ENG_ESTATUS,'') as ENG,isnull(ACT_ESTATUSFAC,'') as FAC,isnull(ACT_ESTATUSENT,'') as ENT, isnull(ACT_ESTATUSAUT,'') as AUT ,isnull(ACT_ESTATUSCOMPRA,'') as COMPRO" &
        " From CRM_PROSPECTOS as PROS LEFT JOIN CRM_VENDEDORES AS VEND ON PROS.PRO_IDvend = VEND.VEND_ID LEFT JOIN CRM_TAC ON PROS.PRO_ID = CRM_TAC.TAC_IDPROS left join CRM_ACTIVIDADES AS ACT ON PROS.PRO_ID = ACT.ACT_IDPROS left join CRM_COMPETIDOR AS COMP ON PROS.PRO_ID = COMP.COM_IDPROS left join CRM_ACCESORIOS AS ACC ON PROS.PRO_ID = ACC.ACC_PROSID LEFT JOIN CRM_PE AS ENG ON PROS.PRO_ID = ENG.PE_IDPROS LEFT JOIN CRM_EC AS EC ON PROS.PRO_ID = EC.EC_IDPROS WHERE isnull(ACT.ACT_ESTATUSFAC,'') <> 'SI' AND VEND.VEND_ID = '" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
        Limpiar()
    End Sub

    Public Sub Limpiar()
        cmbvendedor.Text = ""
        txtmaterno.Text = ""
        txtnombre.Text = ""
        txtpaterno.Text = ""
    End Sub

    Private Sub btnbuscacita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscacita.Click
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE ,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" &
        "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO ,ISNULL((SELECT TOP(1)CIT_FECCITA  FROM CRM_CITAS where CIT_IDPROS = PRO_ID ORDER BY CIT_FECCITA DESC),PRO_FECALTA) AS CITA," &
        "isnull(ACT_ESTATUSATN,'') as ATN,isnull(ACT_ESTATUSPM,'') as PM,isnull(ACT_ESTATUSGE,'') as GE,isnull(ACC_ESTATUS,'') as ACC,isnull(ACT_ESTATUSFI,'') as FI,isnull(TAC_ESTATUS,'') as TAC," &
        "isnull(RTRIM(COM_MARCA1),'') + ' ' +isnull(RTRIM(COM_MARCA2),'') + ' ' + isnull(RTRIM(COM_MARCA3),'') as CMP,isnull(ACT_ESTATUSPE,'') as PE,isnull(ACT_ESTATUSPA,'') as PA,isnull(EC_ESTATUS,'') as CRE,isnull(ENG_ESTATUS,'') as ENG,isnull(ACT_ESTATUSFAC,'') as FAC,isnull(ACT_ESTATUSENT,'') as ENT, isnull(ACT_ESTATUSAUT,'') as AUT ,isnull(ACT_ESTATUSCOMPRA,'') as COMPRO" &
        " From CRM_PROSPECTOS as PROS LEFT JOIN CRM_VENDEDORES AS VEND ON PROS.PRO_IDvend = VEND.VEND_ID LEFT JOIN CRM_TAC ON PROS.PRO_ID = CRM_TAC.TAC_IDPROS left join CRM_ACTIVIDADES AS ACT ON PROS.PRO_ID = ACT.ACT_IDPROS left join CRM_COMPETIDOR AS COMP ON PROS.PRO_ID = COMP.COM_IDPROS LEFT JOIN CRM_CITAS AS CIT ON PROS.PRO_ID = CIT.CIT_IDPROS left join CRM_ACCESORIOS AS ACC ON PROS.PRO_ID = ACC.ACC_PROSID LEFT JOIN CRM_PE AS ENG ON PROS.PRO_ID = ENG.PE_IDPROS LEFT JOIN CRM_EC AS EC ON PROS.PRO_ID = EC.EC_IDPROS WHERE isnull(ACT.ACT_ESTATUSFAC,'') <> 'SI' AND CIT.CIT_FECCITA = '" & dtpcita.Value & "'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
        Limpiar()
    End Sub
End Class