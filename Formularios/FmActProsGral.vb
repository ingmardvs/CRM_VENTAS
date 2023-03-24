Imports System.Data.SqlClient
Public Class FmActProsGral
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim moral As Boolean
    Dim Guardar As String
    Dim Actualiza As String
    Dim contacto As Boolean
    Dim Idcontacto As Integer
    Private Sub FmActPros_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReseteaForm()
    End Sub

    Private Sub Altacliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Idcontacto = 0
        ReseteaForm()
        CargaParametros()
        cmbcon.SelectedIndex = 0
        Cargar_Datos("SELECT PRO_ID,isnull(PRO_NOMBRE,''),isnull(PRO_NOMBRE2,''),isnull(PRO_NOMBRE3,''),isnull(PRO_PATERNO,''),isnull(PRO_MATERNO,''),isnull(PRO_GENERO,''), isnull(PRO_TIPOPER,''),isnull(PRO_RFC,''),isnull(PRO_EDOCIVIL,''),isnull(PRO_CALLE,''),isnull(PRO_COLONIA,''),isnull(PRO_CP,''),isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), isnull(PRO_ENTERO,''), RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR,PRO_CLI1, PRO_CLI2,PRO_MOD1, PRO_MOD2,PRO_PAQ1, PRO_PAQ2,PRO_STATUS1, PRO_STATUS2,isnull(PRO_RAZON,'') AS RAZON FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & Librerias.Id_Bus & "'")
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
        Permisos()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'Información del prospecto
        Conexion.desconectarse()
        If (cmbcon.Text = "PROSPECTO") Then
            'Información del prospecto
            If (MessageBox.Show("¿Desea guardar la información del prospecto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = vbYes Then
                Conexion.dr.Close()
                If (txtnombre.Text = "" Or txtpaterno.Text = "" Or txtmaterno.Text = "" Or mtbrfc.Text = "" Or cmbgenero.Text = "" Or txtcalle.Text = "" Or txtcolonia.Text = "" Or mtbcp.Text = "" Or cmbciudad.Text = "" Or mtbcasa.Text = "" Or mtboficina.Text = "" Or mtbcel.Text = "" Or txtcorreo.Text = "" Or cmbcontacto.Text = "" Or mtbhoraini.Text = "" Or mtbhorafin.Text = "" Or cmbvendedor.Text = "" Or cmbveh1.Text = "" Or cmbmod1.Text = "" Or mtbpaq1.Text = "" Or chkstat1.Checked = False Or CmbEntero.Text = "") Then
                    MsgBox("Verifique que todos los datos esten correctamente llenados.")
                Else
                    Conexion.conectarse()
                    Dim Actualiza As String = "PRO_NOMBRE ='" & txtnombre.Text & "',PRO_NOMBRE2 ='" & txtnombre2.Text & "',PRO_NOMBRE3 ='" & txtnombre3.Text & "',PRO_PATERNO ='" & txtpaterno.Text & "',PRO_MATERNO ='" & txtmaterno.Text & "', PRO_GENERO ='" & cmbgenero.Text & "', PRO_TIPOPER='" & cmbtipoper.Text & "', PRO_RFC ='" & mtbrfc.Text & "', PRO_CALLE ='" & txtcalle.Text & "', PRO_COLONIA='" & txtcolonia.Text & "', PRO_CP='" & mtbcp.Text & "', PRO_CIUDAD='" & cmbciudad.Text & "', PRO_TELCASA='" & mtbcasa.Text & "', PRO_TELOFI='" & mtboficina.Text & "', PRO_TELCEL='" & mtbcel.Text & "',PRO_TELCEL2 ='" & mtbcel2.Text & "', PRO_CORREO='" & txtcorreo.Text & "',PRO_CORREO2 ='" & txtcorreo2.Text & "', PRO_FORCON='" & cmbcontacto.Text & "', PRO_HRINI='" & mtbhoraini.Text & "', PRO_HRFIN='" & mtbhorafin.Text & "',PRO_ENTERO ='" & CmbEntero.Text &
                                                         "', PRO_IDVEND ='" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "', PRO_CLI1 ='" & cmbveh1.Text & "', PRO_CLI2 ='" & cmbveh2.Text & "', PRO_MOD1 ='" & cmbmod1.Text & "', PRO_MOD2 ='" & cmbmod2.Text & "', PRO_PAQ1 ='" & mtbpaq1.Text & "', PRO_PAQ2 ='" & mtbpaq2.Text & "', PRO_STATUS1 ='" & chkstat1.Checked & "', PRO_STATUS2 ='" & chkstat2.Checked & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "', PRO_IDUSU = '" & IdUsu & "', PRO_PERMISOUSU ='" & Permiso & "'"
                    If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, " PRO_ID = '" & Librerias.Id_Bus & "'") Then
                        MsgBox("Prospecto actualizado correctamente")
                        Permisos()
                        Conexion.desconectarse()
                    Else
                        MsgBox("Error al actualizar el prospecto")
                    End If
                    Conexion.desconectarse()
                    Permisos()
                End If
            Else
                MsgBox("No se ha realizado ninguna modificación")
            End If
        ElseIf (cmbcon.Text = "PAGADOR") Then
            bd()
        End If
    End Sub


    Public Sub bd()
        Conexion.Consultar("SELECT PROSREL_ID FROM CRM_PROSREL WHERE PROSREL_PROSID = '" & Librerias.Id_Bus & "'")
        Conexion.dr.Read()
        'si se encuentra información del registro se actualizará
        If (Conexion.dr.HasRows) Then
            Idcontacto = Conexion.dr.GetInt32(0)
            Conexion.dr.Close()
            Conexion.desconectarse()
            Conexion.Consultar("SELECT isnull(PRO_RAZON,'') FROM CRM_PROSPECTOS WHERE PRO_ID = '" & Idcontacto & "'")
            'Este if es para saber si es una persona moral, ya que se consulta el registro de la tabla donde corresponda al pagador relacionado con el prospecto y obtenemos si tiene alguna info en el campo de razon social
            If (Conexion.dr.GetString(0) <> "") Then
                If (MessageBox.Show("¿Desea actualizar la información del pagador?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = vbYes Then
                    Conexion.dr.Close()
                    If (txtnombre.Text = "" Or txtpaterno.Text = "" Or txtmaterno.Text = "" Or mtbrfc.Text = "" Or cmbgenero.Text = "" Or txtcalle.Text = "" Or txtcolonia.Text = "" Or mtbcp.Text = "" Or cmbciudad.Text = "" Or mtbcasa.Text = "" Or mtboficina.Text = "" Or mtbcel.Text = "" Or txtcorreo.Text = "" Or cmbcontacto.Text = "" Or mtbhoraini.Text = "" Or mtbhorafin.Text = "" Or cmbvendedor.Text = "" Or cmbveh1.Text = "" Or cmbmod1.Text = "" Or mtbpaq1.Text = "" Or chkstat1.Checked = False Or CmbEntero.Text = "") Then
                        MsgBox("Verifique que todos los datos esten correctamente llenados.")
                    Else
                        If (moral = False) Then
                            Conexion.conectarse()
                            Dim Actualiza As String = "PRO_NOMBRE ='" & txtnombre.Text & "',PRO_NOMBRE2 ='" & txtnombre2.Text & "',PRO_NOMBRE3 ='" & txtnombre3.Text & "',PRO_PATERNO ='" & txtpaterno.Text & "',PRO_MATERNO ='" & txtmaterno.Text & "', PRO_GENERO ='" & cmbgenero.Text & "', PRO_TIPOPER='" & cmbtipoper.Text & "', PRO_RFC ='" & mtbrfc.Text & "', PRO_CALLE ='" & txtcalle.Text & "', PRO_COLONIA='" & txtcolonia.Text & "', PRO_CP='" & mtbcp.Text & "', PRO_CIUDAD='" & cmbciudad.Text & "', PRO_TELCASA='" & mtbcasa.Text & "', PRO_TELOFI='" & mtboficina.Text & "', PRO_TELCEL='" & mtbcel.Text & "',PRO_TELCEL2 ='" & mtbcel2.Text & "', PRO_CORREO='" & txtcorreo.Text & "',PRO_CORREO2 ='" & txtcorreo2.Text & "', PRO_FORCON='" & cmbcontacto.Text & "', PRO_HRINI='" & mtbhoraini.Text & "', PRO_HRFIN='" & mtbhorafin.Text & "',PRO_ENTERO ='" & CmbEntero.Text &
                                                                 "', PRO_IDVEND ='" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "', PRO_CLI1 ='" & cmbveh1.Text & "', PRO_CLI2 ='" & cmbveh2.Text & "', PRO_MOD1 ='" & cmbmod1.Text & "', PRO_MOD2 ='" & cmbmod2.Text & "', PRO_PAQ1 ='" & mtbpaq1.Text & "', PRO_PAQ2 ='" & mtbpaq2.Text & "', PRO_STATUS1 ='" & chkstat1.Checked & "', PRO_STATUS2 ='" & chkstat2.Checked & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "', PRO_IDUSU = '" & IdUsu & "', PRO_PERMISOUSU ='" & Permiso & "'"
                            If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, " PRO_ID = '" & Librerias.Id_Bus & "'") Then
                                MsgBox("Prospecto actualizado correctamente")
                                Permisos()
                                Actualiza = "PROS_ID ='" & txtid.Text & "'"
                                If (Conexion.Actualizar("CRM_PROSREL", Actualiza, " PROSREL_ID ='" & Idcontacto & "'")) Then
                                    MsgBox("Contacto actualizado correctamente.")
                                Else
                                    MsgBox("Error al actualizar contacto.")
                                End If
                                Conexion.desconectarse()
                            Else
                                MsgBox("Error al actualizar el prospecto")
                            End If
                            Conexion.desconectarse()
                            Permisos()
                        Else
                            Conexion.conectarse()
                            Dim Actualiza As String = "PRO_RAZON ='" & txtrazonsocial.Text & "', PRO_TIPOPER='" & cmbtipoper.Text & "', PRO_RFC ='" & mtbrfc.Text & "', PRO_CALLE ='" & txtcalle.Text & "', PRO_COLONIA='" & txtcolonia.Text & "', PRO_CP='" & mtbcp.Text & "', PRO_CIUDAD='" & cmbciudad.Text & "', PRO_TELCASA='" & mtbcasa.Text & "', PRO_TELOFI='" & mtboficina.Text & "', PRO_TELCEL='" & mtbcel.Text & "',PRO_TELCEL2 ='" & mtbcel2.Text & "', PRO_CORREO='" & txtcorreo.Text & "',PRO_CORREO2 ='" & txtcorreo2.Text & "', PRO_FORCON='" & cmbcontacto.Text & "', PRO_HRINI='" & mtbhoraini.Text & "', PRO_HRFIN='" & mtbhorafin.Text & "',PRO_ENTERO ='" & CmbEntero.Text &
                                                                 "', PRO_IDVEND ='" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "', PRO_CLI1 ='" & cmbveh1.Text & "', PRO_CLI2 ='" & cmbveh2.Text & "', PRO_MOD1 ='" & cmbmod1.Text & "', PRO_MOD2 ='" & cmbmod2.Text & "', PRO_PAQ1 ='" & mtbpaq1.Text & "', PRO_PAQ2 ='" & mtbpaq2.Text & "', PRO_STATUS1 ='" & chkstat1.Checked & "', PRO_STATUS2 ='" & chkstat2.Checked & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "', PRO_IDUSU = '" & IdUsu & "', PRO_PERMISOUSU ='" & Permiso & "'"
                            If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, " PRO_ID = '" & Librerias.Id_Bus & "'") Then
                                MsgBox("Prospecto actualizado correctamente")
                                Permisos()
                                Actualiza = "PROS_ID ='" & txtid.Text & "'"
                                If (Conexion.Actualizar("CRM_PROSREL", Actualiza, " PROSREL_ID ='" & Idcontacto & "'")) Then
                                    MsgBox("Contacto actualizado correctamente.")
                                Else
                                    MsgBox("Error al actualizar contacto.")
                                End If
                                Conexion.desconectarse()
                            Else
                                MsgBox("Error al actualizar el prospecto")
                            End If
                            Conexion.desconectarse()
                            Permisos()
                        End If
                    End If
                Else
                    MsgBox("No se ha realizado ninguna modificación")
                End If




            Else
                'Si no existe se insertará
                Conexion.dr.Close()
                If (contacto = True And moral = False) Then
                    Guardar = "INSERT INTO CRM_PROSPECTOS(PRO_TIPOPER,PRO_NOMBRE,PRO_NOMBRE2,PRO_NOMBRE3,PRO_PATERNO,PRO_MATERNO,PRO_RFC,PRO_GENERO,PRO_ENTERO,PRO_CALLE,PRO_COLONIA,PRO_CP,PRO_CIUDAD,PRO_TELCASA,PRO_TELOFI,PRO_TELCEL,PRO_CORREO,PRO_TELCEL2,PRO_CORREO2,PRO_FORCON,PRO_HRINI,PRO_HRFIN,PRO_IDVEND,PRO_CLI1,PRO_CLI2,PRO_MOD1,PRO_MOD2,PRO_PAQ1,PRO_PAQ2,PRO_STATUS1,PRO_STATUS2,PRO_FECALTA,PRO_HORALTA,PRO_IDUSU,PRO_PERMISOUSU)" &
                  "VALUES('" & cmbtipoper.Text & "','" & txtnombre.Text & "','" & txtnombre2.Text & "','" & txtnombre3.Text & "','" & txtpaterno.Text & "','" & txtmaterno.Text & "','" & mtbrfc.Text & "','" & cmbgenero.Text & "','" & CmbEntero.Text & "','" & txtcalle.Text & "','" & txtcolonia.Text & "','" & mtbcp.Text & "','" & cmbciudad.Text & "','" & mtbcasa.Text & "','" & mtboficina.Text & "','" & mtbcel.Text & "','" & txtcorreo.Text & "','" & mtbcel2.Text & "','" & txtcorreo2.Text & "','" & cmbcontacto.Text & "','" & mtbhoraini.Text & "','" & mtbhorafin.Text & "','" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "','" & cmbveh1.Text & "','" & cmbveh2.Text & "','" & cmbmod1.Text & "','" & cmbmod2.Text & "','" & mtbpaq1.Text & "','" & mtbpaq2.Text & "','" & chkstat1.Checked & "','" & chkstat2.Checked & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
                    If (Conexion.Insertar(Guardar)) Then
                        MsgBox("Se ha ingresado correctamente el contacto.")
                        Me.Close()
                        Permisos()
                        CargaContacto()
                        Conexion.conectarse()
                        Guardar = "INSERT INTO CRM_PROSREL VALUES('" & Id_Bus & "','" & Idcontacto & "')"
                        If (Conexion.Insertar(Guardar)) Then
                            MsgBox("Se ha relacionado correctamente")
                        Else
                            MsgBox("Ocurrio un error al relacionar el pospecto con el contacto")
                        End If
                        Conexion.desconectarse()
                    Else
                        MsgBox("Ocurrio un error al intentar ingresar el contacto.")
                    End If
                    Conexion.desconectarse()
                ElseIf contacto = True And moral = True Then
                    Guardar = "INSERT INTO CRM_PROSPECTOS(PRO_NOMBRE,PRO_TIPOPER,PRO_RAZON,PRO_RFC,PRO_ENTERO,PRO_CALLE,PRO_COLONIA,PRO_CP,PRO_CIUDAD,PRO_TELCASA,PRO_TELOFI,PRO_TELCEL,PRO_CORREO,PRO_TELCEL2,PRO_CORREO2,PRO_FORCON,PRO_HRINI,PRO_HRFIN,PRO_IDVEND,PRO_CLI1,PRO_CLI2,PRO_MOD1,PRO_MOD2,PRO_PAQ1,PRO_PAQ2,PRO_STATUS1,PRO_STATUS2,PRO_FECALTA,PRO_HORALTA,PRO_IDUSU,PRO_PERMISOUSU)" &
                  "VALUES('" & txtrazonsocial.Text & "','" & cmbtipoper.Text & "','" & txtrazonsocial.Text & "','" & mtbrfc.Text & "','" & CmbEntero.Text & "','" & txtcalle.Text & "','" & txtcolonia.Text & "','" & mtbcp.Text & "','" & cmbciudad.Text & "','" & mtbcasa.Text & "','" & mtboficina.Text & "','" & mtbcel.Text & "','" & txtcorreo.Text & "','" & mtbcel2.Text & "','" & txtcorreo2.Text & "','" & cmbcontacto.Text & "','" & mtbhoraini.Text & "','" & mtbhorafin.Text & "','" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "','" & cmbveh1.Text & "','" & cmbveh2.Text & "','" & cmbmod1.Text & "','" & cmbmod2.Text & "','" & mtbpaq1.Text & "','" & mtbpaq2.Text & "','" & chkstat1.Checked & "','" & chkstat2.Checked & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
                    If (Conexion.Insertar(Guardar)) Then
                        MsgBox("Se ha ingresado correctamente el contacto.")
                        Me.Close()
                        Permisos()
                        Conexion.conectarse()
                        CargaContacto()
                        Guardar = "INSERT INTO CRM_PROSREL VALUES('" & Id_Bus & "','" & Idcontacto & "')"
                        If (Conexion.Insertar(Guardar)) Then
                            MsgBox("Se ha relacionado correctamente")
                        Else
                            MsgBox("Ocurrio un error al relacionar el pospecto con el contacto")
                        End If
                        Conexion.desconectarse()
                    Else
                        MsgBox("Ocurrio un error al intentar ingresar el contacto.")
                    End If
                    Conexion.desconectarse()
                End If
            End If



        Else

        End If
    End Sub

    Private Sub CargaParametros()
        btnbuscarmoral.Visible = False
        cmbcontacto.Text = "PROSPECTO"
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CLI' and PAR_STATUS = 'ACTIVO'", cmbveh1)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CLI' and PAR_STATUS = 'ACTIVO'", cmbveh2)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'MOD' and PAR_STATUS = 'ACTIVO'", cmbmod1)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'MOD' and PAR_STATUS = 'ACTIVO'", cmbmod2)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'ENT' and PAR_STATUS = 'ACTIVO'", CmbEntero)
        Conexion.LlenarCombo("SELECT RTRIM(VEND_NOMBRE) + ' ' + RTRIM(VEND_PATERNO) + ' ' +VEND_MATERNO+' -'+ convert(varchar(4),VEND_ID) AS NOMBRE FROM CRM_VENDEDORES ORDER BY VEND_NOMBRE ASC", cmbvendedor)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CD' and PAR_STATUS = 'ACTIVO'", cmbciudad)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'GENER' and PAR_STATUS = 'ACTIVO'", cmbgenero)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'FC' and PAR_STATUS = 'ACTIVO'", cmbcontacto)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'TP' and PAR_STATUS = 'ACTIVO'", cmbtipoper)
    End Sub

    Private Sub CargaContacto()
        If (moral = True) Then
            Conexion.Consultar("SELECT PRO_ID FROM CRM_PROSPECTOS WHERE PRO_RAZON = '" & txtrazonsocial.Text & "'")
        Else
            Conexion.Consultar("SELECT PRO_ID FROM CRM_PROSPECTOS WHERE PRO_NOMBRE = '" & txtnombre.Text & "' AND PRO_NOMBRE2 = '" & txtnombre2.Text & "' AND PRO_NOMBRE3 ='" & txtnombre3.Text & "' AND PRO_PATERNO ='" & txtpaterno.Text & "' AND PRO_MATERNO ='" & txtmaterno.Text & "'")
        End If
        Conexion.dr.Read()
        If (Conexion.dr.IsDBNull(0)) Then
        Else
            If Conexion.dr.HasRows Then
                Idcontacto = Conexion.dr.GetInt32(0)
                Conexion.dr.Close()
                Conexion.desconectarse()
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
        End If
    End Sub

    Public Sub LigarMoralVSFisica()
        'Para poder ligar la información del prospecto se debe de tener llenada la información de la persona moral, si ya existe esa persona simplemente se debe de buscar
        MsgBox("CONSULTA: " & "Select PRO_IDPERMORAL, PRO_RAZON from CRM_PROSPECTOS where PRO_RFC like '" & mtbrfcm.Text & "' AND PRO_RAZON like '" & txtrazonsocial.Text & "'")
        Conexion.Consultar("Select PRO_ID, PRO_RAZON from CRM_PROSPECTOS where PRO_RFC like '" & mtbrfcm.Text & "' AND PRO_RAZON like '" & txtrazonsocial.Text & "'")
        If (Conexion.dr.HasRows) Then
            Conexion.dr.Read()
            Actualiza = "PRO_IDPERMORAL ='" & Conexion.dr.GetInt32(0) & "', PRO_RAZON='" & Conexion.dr.GetString(1) & "', PRO_FECALTA='" & DateTime.Today & "', PRO_HORALTA='" & Now.ToString("HH:MM") & "', PRO_IDUSU='" & IdUsu & "', PRO_PERMISOUSU='" & Permiso & "'"
            Conexion.dr.Close()
            If (Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, " PRO_ID = '" & Librerias.Id_Bus & "'")) Then
                MsgBox("Se ha ligado correctamente la Persona Moral.")
                Me.Close()
                Permisos()
                Conexion.desconectarse()
            Else
                MsgBox("Ocurrio un error al intentar ligar la Persona Moral.")
            End If
            Conexion.desconectarse()
        Else
        End If
    End Sub

    Public Sub ValidoMoral()
        Dim razon, rfcm As String
        If txtrazonsocial.Text <> "" Then razon = "%" + txtrazonsocial.Text + "%"
        If mtbrfcm.Text <> "    -    -   " Then rfcm = "%" + mtbrfcm.Text + "%"
        Conexion.Consultar("SELECT * FROM CRM_PROSPECTOS WHERE PRO_RFC like '" & rfcm & "' AND PRO_RAZON like '" & razon & "'")
        txtrazonsocial.Text = txtrazonsocial.Text
        mtbrfcm.Text = mtbrfcm.Text
        If (Conexion.dr.HasRows) Then
            Conexion.dr.Close()
            Conexion.desconectarse()
            Conexion.conectarse()
            Actualiza = "PRO_RAZON ='" & txtrazonsocial.Text & "', PRO_RFC ='" & mtbrfc.Text & "', PRO_CALLE ='" & txtcalle.Text & "', PRO_COLONIA='" & txtcolonia.Text & "', PRO_CP='" & mtbcp.Text & "', PRO_CIUDAD='" & cmbciudad.Text & "', PRO_TELCASA='" & mtbcasa.Text & "', PRO_TELOFI='" & mtboficina.Text & "', PRO_TELCEL='" & mtbcel.Text & "',PRO_TELCEL2 ='" & mtbcel2.Text & "', PRO_CORREO='" & txtcorreo.Text & "',PRO_CORREO2 ='" & txtcorreo2.Text & "', PRO_FORCON='" & cmbcontacto.Text & "', PRO_HRINI='" & mtbhoraini.Text & "', PRO_HRFIN='" & mtbhorafin.Text & "',PRO_ENTERO ='" & CmbEntero.Text &
                                                    "', PRO_IDVEND ='" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "', PRO_CLI1 ='" & cmbveh1.Text & "', PRO_CLI2 ='" & cmbveh2.Text & "', PRO_MOD1 ='" & cmbmod1.Text & "', PRO_MOD2 ='" & cmbmod2.Text & "', PRO_PAQ1 ='" & mtbpaq1.Text & "', PRO_PAQ2 ='" & mtbpaq2.Text & "', PRO_STATUS1 ='" & chkstat1.Checked & "', PRO_STATUS2 ='" & chkstat2.Checked & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "', PRO_IDUSU = '" & IdUsu & "', PRO_PERMISOUSU ='" & Permiso & "'"
            If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, " PRO_ID = '" & Librerias.Id_Bus & "'") Then
                MsgBox("Persona moral actualizada correctamente")
                Conexion.desconectarse()
            Else
                MsgBox("Error al actualizar la persona moral")
            End If
            Conexion.desconectarse()


        Else
            Conexion.dr.Close()
            Guardar = "INSERT INTO CRM_PROSPECTOS (PRO_NOMBRE,PRO_NOMBRE2,PRO_NOMBRE3,PRO_PATERNO,PRO_MATERNO,PRO_RAZON,PRO_RFC,PRO_CALLE,PRO_COLONIA,PRO_CP,PRO_CIUDAD,PRO_TELCASA,PRO_TELOFI,PRO_TELCEL,PRO_TELCEL2,PRO_CORREO,PRO_CORREO2,PRO_FORCON,PRO_HRINI,PRO_HRFIN,PRO_ENTERO,PRO_IDVEND,PRO_CLI1,PRO_CLI2,PRO_MOD1,PRO_MOD2,PRO_PAQ1,PRO_PAQ2,PRO_STATUS1,PRO_STATUS2,PRO_FECALTA,PRO_HORALTA,PRO_IDUSU,PRO_PERMISOUSU,PRO_PERMORAL) " &
                "VALUES('','','','','','" & txtrazonsocial.Text & "','" & mtbrfcm.Text & "','" & txtcalle.Text & "','" & txtcolonia.Text & "','" & mtbcp.Text & "','" & cmbciudad.Text & "','" & mtbcasa.Text & "','" & mtboficina.Text & "','" & mtbcel.Text & "','" & mtbcel2.Text & "','" & txtcorreo.Text & "','" & txtcorreo2.Text & "','" & cmbcontacto.Text & "','" & mtbhoraini.Text & "','" & mtbhorafin.Text & "','" & CmbEntero.Text & "','" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "','" & cmbveh1.Text & "','" & cmbveh2.Text & "','" & cmbmod1.Text & "','" & cmbmod2.Text & "','" & mtbpaq1.Text & "','" & mtbpaq2.Text & "','" & chkstat1.Checked & "','" & chkstat2.Checked & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "','S')"
            If (Conexion.Insertar(Guardar)) Then
                MsgBox("Se ha ingresado correctamente la Persona Moral.")


                Conexion.desconectarse()
            Else
                MsgBox("Ocurrio un error al intentar guardar la Persona Moral.")
            End If
            Conexion.desconectarse()
        End If
    End Sub


    Private Sub ValidaMoral()
        MsgBox(Id_Moral)
        Conexion.Consultar("SELECT PRO_ID FROM CRM_PROSPECTOS WHERE PRO_ID = '" & Id_Moral & "'")
        Conexion.dr.Read()
        If (Conexion.dr.HasRows) Then
            Conexion.dr.Close()
            Conexion.desconectarse()
            Conexion.conectarse()
            Actualiza = "PRO_RAZON ='" & txtrazonsocial.Text & "', PRO_RFC ='" & mtbrfc.Text & "', PRO_CALLE ='" & txtcalle.Text & "', PRO_COLONIA='" & txtcolonia.Text & "', PRO_CP='" & mtbcp.Text & "', PRO_CIUDAD='" & cmbciudad.Text & "', PRO_TELCASA='" & mtbcasa.Text & "', PRO_TELOFI='" & mtboficina.Text & "', PRO_TELCEL='" & mtbcel.Text & "',PRO_TELCEL2 ='" & mtbcel2.Text & "', PRO_CORREO='" & txtcorreo.Text & "',PRO_CORREO2 ='" & txtcorreo2.Text & "', PRO_FORCON='" & cmbcontacto.Text & "', PRO_HRINI='" & mtbhoraini.Text & "', PRO_HRFIN='" & mtbhorafin.Text & "',PRO_ENTERO ='" & CmbEntero.Text &
                                                    "', PRO_IDVEND ='" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "', PRO_CLI1 ='" & cmbveh1.Text & "', PRO_CLI2 ='" & cmbveh2.Text & "', PRO_MOD1 ='" & cmbmod1.Text & "', PRO_MOD2 ='" & cmbmod2.Text & "', PRO_PAQ1 ='" & mtbpaq1.Text & "', PRO_PAQ2 ='" & mtbpaq2.Text & "', PRO_STATUS1 ='" & chkstat1.Checked & "', PRO_STATUS2 ='" & chkstat2.Checked & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "', PRO_IDUSU = '" & IdUsu & "', PRO_PERMISOUSU ='" & Permiso & "'"
            If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, " PRO_ID = '" & Librerias.Id_Bus & "'") Then
                MsgBox("Persona moral actualizada correctamente")
                Permisos()
                Conexion.desconectarse()
            Else
                MsgBox("Error al actualizar la persona moral")
            End If
            Conexion.desconectarse()
            Me.Close()
            Permisos()
        Else
            'metodo para obtener el id de la persona moral relacionada a la persona fisica
            Conexion.dr.Close()
            Guardar = "INSERT INTO CRM_PROSPECTOS (PRO_NOMBRE,PRO_NOMBRE2,PRO_NOMBRE3,PRO_PATERNO,PRO_MATERNO,PRO_RAZON,PRO_RFC,PRO_CALLE,PRO_COLONIA,PRO_CP,PRO_CIUDAD,PRO_TELCASA,PRO_TELOFI,PRO_TELCEL,PRO_TELCEL2,PRO_CORREO,PRO_CORREO2,PRO_FORCON,PRO_HRINI,PRO_HRFIN,PRO_ENTERO,PRO_IDVEND,PRO_CLI1,PRO_CLI2,PRO_MOD1,PRO_MOD2,PRO_PAQ1,PRO_PAQ2,PRO_STATUS1,PRO_STATUS2,PRO_FECALTA,PRO_HORALTA,PRO_IDUSU,PRO_PERMISOUSU) " &
                "VALUES('X','X','X','X','X','" & txtrazonsocial.Text & "','" & mtbrfcm.Text & "','" & txtcalle.Text & "','" & txtcolonia.Text & "','" & mtbcp.Text & "','" & cmbciudad.Text & "','" & mtbcasa.Text & "','" & mtboficina.Text & "','" & mtbcel.Text & "','" & mtbcel2.Text & "','" & txtcorreo.Text & "','" & txtcorreo2.Text & "','" & cmbcontacto.Text & "','" & mtbhoraini.Text & "','" & mtbhorafin.Text & "','" & CmbEntero.Text & "','" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "','" & cmbveh1.Text & "','" & cmbveh2.Text & "','" & cmbmod1.Text & "','" & cmbmod2.Text & "','" & mtbpaq1.Text & "','" & mtbpaq2.Text & "','" & chkstat1.Checked & "','" & chkstat2.Checked & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
            If (Conexion.Insertar(Guardar)) Then
                MsgBox("Se ha ingresado correctamente la Persona Moral.")
                Me.Close()
                Permisos()
                Conexion.desconectarse()
            Else
                MsgBox("Ocurrio un error al intentar guardar la Persona Moral.")
            End If
            Conexion.desconectarse()
        End If
    End Sub

    Private Sub CargaMoral()
        Conexion.Consultar("SELECT PRO_IDPERMORAL FROM CRM_PROSPECTOS WHERE PRO_ID = '" & Id_Bus & "'")
        Conexion.dr.Read()

        If (Conexion.dr.IsDBNull(0)) Then
        Else
            If Conexion.dr.HasRows Then
                If (Conexion.dr.GetInt32(0) <> "0") Then
                    Id_Moral = Conexion.dr.GetInt32(0)
                    Conexion.dr.Close()
                    Conexion.desconectarse()
                    Cargar_DatosMoral("SELECT PRO_IDPERMORAL, PRO_RAZON, isnull(PRO_RFC,''), isnull(PRO_CALLE,''), isnull(PRO_COLONIA,''), isnull(PRO_CP,''), isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), PRO_ENTERO, RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & Librerias.Id_Bus & "'")
                    Conexion.desconectarse()
                End If
                Conexion.dr.Close()
                Conexion.desconectarse()
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
        End If
    End Sub

    Public Sub ReseteaForm()
        moral = False
        Limpiar()
        mtbrfcm.Visible = False
        lblrazon.Visible = False
        txtrazonsocial.Visible = False
        lblrfcm.Visible = False
        lblnombre.Visible = True
        lblnombre2.Visible = True
        lblnombre3.Visible = True
        lblpat.Visible = True
        lblmat.Visible = True
        txtnombre.Visible = True
        txtnombre2.Visible = True
        txtnombre3.Visible = True
        txtmaterno.Visible = True
        txtpaterno.Visible = True
        lblgen.Visible = True
        cmbgenero.Visible = True
        lblrfcf.Visible = True
        mtbrfc.Visible = True
        cmbvendedor.Enabled = True
    End Sub

    Private Sub Cargar_DatosMoral(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtid.Text = Conexion.dr.GetInt32(0)
            txtrazonsocial.Text = RTrim(Conexion.dr.GetString(1))
            cmbtipoper.Text = RTrim(Conexion.dr.GetString(2))
            mtbrfcm.Text = Conexion.dr.GetString(3)
            txtcalle.Text = RTrim(Conexion.dr.GetString(4))
            txtcolonia.Text = RTrim(Conexion.dr.GetString(5))
            mtbcp.Text = Conexion.dr.GetString(6)
            cmbciudad.Text = Conexion.dr.GetString(7)
            mtbcasa.Text = Conexion.dr.GetString(8)
            mtboficina.Text = Conexion.dr.GetString(9)
            mtbcel.Text = Conexion.dr.GetString(10)
            mtbcel2.Text = Conexion.dr.GetString(11)
            txtcorreo.Text = RTrim(Conexion.dr.GetString(12))
            txtcorreo2.Text = RTrim(Conexion.dr.GetString(13))
            cmbcontacto.Text = RTrim(Conexion.dr.GetString(14))
            mtbhoraini.Text = Conexion.dr.GetString(15)
            mtbhorafin.Text = Conexion.dr.GetString(16)
            CmbEntero.Text = RTrim(Conexion.dr.GetString(17))
            cmbvendedor.Text = RTrim(Conexion.dr.GetString(18))
            cmbveh1.Text = RTrim(Conexion.dr.GetString(19))
            cmbveh2.Text = RTrim(Conexion.dr.GetString(20))
            cmbmod1.Text = Conexion.dr.GetString(21)
            cmbmod2.Text = Conexion.dr.GetString(22)
            mtbpaq1.Text = Conexion.dr.GetString(23)
            mtbpaq2.Text = Conexion.dr.GetString(24)
            chkstat1.Checked = Conexion.dr.GetBoolean(25)
            chkstat2.Checked = Conexion.dr.GetBoolean(26)
            If Len(cmbveh2.Text) <> 0 And Len(cmbmod2.Text) <> 0 Then chkstat2.Enabled = True Else chkstat2.Enabled = False
            Conexion.dr.Close()
            Conexion.desconectarse()
        Else
            MsgBox("No hay información.")
            Limpiar()
            Conexion.desconectarse()
        End If
        Conexion.desconectarse()
    End Sub


    Private Sub Limpiar()
        txtid.Text = Nothing
        txtnombre.Text = ""
        txtnombre2.Text = ""
        txtnombre3.Text = ""
        txtpaterno.Text = ""
        txtmaterno.Text = ""
        mtbcel2.Text = ""
        txtcorreo2.Text = ""
        mtbrfc.Text = ""
        txtcalle.Text = ""
        txtcolonia.Text = ""
        mtbcp.Text = ""
        mtbcasa.Text = ""
        mtboficina.Text = ""
        mtbcel.Text = ""
        txtcorreo.Text = ""
        mtbhoraini.Text = ""
        mtbhorafin.Text = ""
        mtbrfcm.Text = ""
        txtrazonsocial.Text = ""
        cmbcontacto.Items.Clear()
        cmbcontacto.Text = "PROSPECTO"
        cmbtipoper.Items.Clear()
        cmbtipoper.Text = ""
        cmbciudad.Text = ""
        cmbciudad.Items.Clear()
        cmbgenero.Text = ""
        cmbgenero.Items.Clear()
        cmbveh1.Items.Clear()
        cmbveh2.Text = ""
        cmbveh2.Items.Clear()
        cmbmod1.Text = ""
        cmbmod1.Items.Clear()
        cmbmod2.Text = ""
        cmbmod2.Items.Clear()
        CmbEntero.Text = ""
        CmbEntero.Items.Clear()
        cmbvendedor.Text = ""
        cmbvendedor.Items.Clear()
    End Sub

    Public Sub Permisos()
        Select Case Permiso
            Case 9
                FmSeguimientoAcc.Mostrar_Datos()
            Case 8
                FmSeguimientoEnt.Mostrar_Datos()
            Case 7
                FmSeguimientoAux.Mostrar_Datos()
            Case 6
                FmSeguimientoBDC.Mostrar_Datos()
            Case 5
                FmSeguimientoVal.Mostrar_Datos()
            Case 4
                FmSeguimientoFI.Mostrar_Datos()
            Case 2
                FmSeguimientoVend.Mostrar_Datos()
            Case 1
                FmSeguimientoGTES.Mostrar_Datos()
            Case 0
                FmSeguimiento.Mostrar_Datos()
        End Select
    End Sub

    Private Sub Cargar_Datos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtid.Text = Conexion.dr.GetInt32(0)
            txtnombre.Text = RTrim(Conexion.dr.GetString(1))
            txtnombre2.Text = RTrim(Conexion.dr.GetString(2))
            txtnombre3.Text = RTrim(Conexion.dr.GetString(3))
            txtpaterno.Text = RTrim(Conexion.dr.GetString(4))
            txtmaterno.Text = RTrim(Conexion.dr.GetString(5))
            cmbgenero.Text = RTrim(Conexion.dr.GetString(6))
            txtrazonsocial.Text = Conexion.dr.GetString(7)
            cmbtipoper.Text = RTrim(Conexion.dr.GetString(8))
            mtbrfc.Text = Conexion.dr.GetString(9)
            txtcalle.Text = RTrim(Conexion.dr.GetString(10))
            txtcolonia.Text = RTrim(Conexion.dr.GetString(11))
            mtbcp.Text = Conexion.dr.GetString(12)
            cmbciudad.Text = Conexion.dr.GetString(13)
            mtbcasa.Text = Conexion.dr.GetString(14)
            mtboficina.Text = Conexion.dr.GetString(15)
            mtbcel.Text = Conexion.dr.GetString(16)
            mtbcel2.Text = Conexion.dr.GetString(17)
            txtcorreo.Text = RTrim(Conexion.dr.GetString(18))
            txtcorreo2.Text = RTrim(Conexion.dr.GetString(19))
            cmbcontacto.Text = RTrim(Conexion.dr.GetString(20))
            mtbhoraini.Text = Conexion.dr.GetString(21)
            mtbhorafin.Text = Conexion.dr.GetString(22)
            CmbEntero.Text = RTrim(Conexion.dr.GetString(23))
            cmbvendedor.Text = RTrim(Conexion.dr.GetString(24))
            cmbveh1.Text = RTrim(Conexion.dr.GetString(25))
            cmbveh2.Text = RTrim(Conexion.dr.GetString(26))
            cmbmod1.Text = Conexion.dr.GetString(27)
            cmbmod2.Text = Conexion.dr.GetString(28)
            mtbpaq1.Text = Conexion.dr.GetString(29)
            mtbpaq2.Text = Conexion.dr.GetString(30)
            chkstat1.Checked = Conexion.dr.GetBoolean(31)
            chkstat2.Checked = Conexion.dr.GetBoolean(32)
            If Len(cmbveh2.Text) <> 0 And Len(cmbmod2.Text) <> 0 Then chkstat2.Enabled = True Else chkstat2.Enabled = False
            Conexion.dr.Close()
        Else
            MsgBox("No hay información.")
            Limpiar()
        End If
        Conexion.desconectarse()
    End Sub

    Private Sub CmbVeh1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbveh1.SelectedIndexChanged, cmbmod1.SelectedIndexChanged, mtbpaq1.TextChanged
        If Len(cmbveh1.Text) > 0 And Len(cmbmod1.Text) > 0 And Len(mtbpaq1.Text) > 0 Then chkstat1.Checked = True Else chkstat1.Checked = False
    End Sub

    Private Sub CmbVeh2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbveh2.SelectedIndexChanged, cmbmod2.SelectedIndexChanged, mtbpaq2.TextChanged
        If Len(cmbveh2.Text) > 0 And Len(cmbmod2.Text) > 0 And Len(mtbpaq2.Text) > 0 Then chkstat2.Enabled = True Else chkstat2.Enabled = False
        If Len(cmbveh2.Text) > 0 And Len(cmbmod2.Text) > 0 And Len(mtbpaq2.Text) > 0 Then chkstat2.Checked = True Else chkstat2.Checked = False
    End Sub

    Private Sub btnmoral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoral.Click
        txtid.Enabled = True
        btnbuscarmoral.Visible = True
        moral = True
        mtbrfcm.Visible = True
        lblrazon.Visible = True
        txtrazonsocial.Visible = True
        lblrfcm.Visible = True
        lblnombre.Visible = False
        lblnombre2.Visible = False
        lblnombre3.Visible = False
        lblpat.Visible = False
        lblmat.Visible = False
        txtnombre.Visible = False
        txtnombre2.Visible = False
        txtnombre3.Visible = False
        txtmaterno.Visible = False
        txtpaterno.Visible = False
        lblgen.Visible = False
        cmbgenero.Visible = False
        lblrfcf.Visible = False
        mtbrfc.Visible = False
        txtid.Text = ""
        Conexion.desconectarse()
        CargaMoral()
        Conexion.desconectarse()
    End Sub

    Private Sub btnbuscarmoral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmoral.Click
        'If txtrazonsocial.Text <> "" Then txtrazonsocial.Text = "%" + txtrazonsocial.Text + "%"
        '"SELECT PRO_IDPERMORAL, PRO_RAZON, isnull(PRO_RFC,''), isnull(PRO_CALLE,''), isnull(PRO_COLONIA,''), isnull(PRO_CP,''), isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), PRO_ENTERO, RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_RFC like '%" & mtbrfcm.Text & "%' or PRO_RAZON like '%" & txtrazonsocial.Text & "%' or PRO_ID ='" & txtid.Text & "'"
        If (txtid.Text <> "" And cmbtipoper.Text = "MORAL") Then
            Cargar_Datos("SELECT PRO_ID, PRO_NOMBRE, PRO_NOMBRE2, PRO_NOMBRE3, PRO_PATERNO, PRO_MATERNO, isnull(PRO_GENERO,''),PRO_RAZON,isnull(PRO_TIPOPER,''), isnull(PRO_RFC,''), isnull(PRO_CALLE,''), isnull(PRO_COLONIA,''), isnull(PRO_CP,''), isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), PRO_ENTERO, RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & txtid.Text & "'")

        ElseIf (txtid.Text <> "" And cmbtipoper.Text = "FISICA") Then
            Cargar_Datos("SELECT PRO_ID, PRO_NOMBRE, PRO_NOMBRE2, PRO_NOMBRE3, PRO_PATERNO, PRO_MATERNO, isnull(PRO_GENERO,''),isnull(PRO_TIPOPER,''), isnull(PRO_RFC,''), isnull(PRO_EDOCIVIL,''), isnull(PRO_CALLE,''), isnull(PRO_COLONIA,''), isnull(PRO_CP,''), isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), PRO_ENTERO, RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & txtid.Text & "'")

        ElseIf (txtid.Text = "" And cmbtipoper.Text = "MORAL") Then
            Cargar_Datos("SELECT PRO_ID, PRO_NOMBRE, PRO_NOMBRE2, PRO_NOMBRE3, PRO_PATERNO, PRO_MATERNO, isnull(PRO_GENERO,''),isnull(PRO_TIPOPER,''), isnull(PRO_RFC,''), isnull(PRO_EDOCIVIL,''), isnull(PRO_CALLE,''), isnull(PRO_COLONIA,''), isnull(PRO_CP,''), isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), PRO_ENTERO, RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_NOMBRE LIKE '" & txtnombre.Text & "%' OR PRO_NOMBRE2 LIKE '" & txtnombre2.Text & "%' OR PRO_NOMBRE3 LIKE '" & txtnombre3.Text & "%' OR PRO_PATERNO LIKE '" & txtpaterno.Text & "%' OR PRO_MATERNO LIKE '" & txtmaterno.Text & "%'")

        ElseIf (txtid.Text = "" And cmbtipoper.Text = "FISICA") Then
            Cargar_Datos("SELECT PRO_ID, PRO_RAZON, isnull(PRO_RFC,''), isnull(PRO_CALLE,''), isnull(PRO_COLONIA,''), isnull(PRO_CP,''), isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), PRO_ENTERO, RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & txtid.Text & "'")

        End If
    End Sub
   

    Private Sub cmbtipoper_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbtipoper.SelectedIndexChanged
        If (cmbtipoper.Text = "MORAL") Then
            txtid.Enabled = True
            moral = True
            mtbrfcm.Visible = True
            lblrazon.Visible = True
            txtrazonsocial.Visible = True
            lblrfcm.Visible = True
            lblnombre.Visible = False
            lblnombre2.Visible = False
            lblnombre3.Visible = False
            lblpat.Visible = False
            lblmat.Visible = False
            txtnombre.Visible = False
            txtnombre2.Visible = False
            txtnombre3.Visible = False
            txtmaterno.Visible = False
            txtpaterno.Visible = False
            lblgen.Visible = False
            cmbgenero.Visible = False
            lblrfcf.Visible = False
            mtbrfc.Visible = False
        Else
            mtbrfcm.Visible = False
            lblrazon.Visible = False
            txtrazonsocial.Visible = False
            lblrfcm.Visible = False
            lblnombre.Visible = True
            lblnombre2.Visible = True
            lblnombre3.Visible = True
            lblpat.Visible = True
            lblmat.Visible = True
            txtnombre.Visible = True
            txtnombre2.Visible = True
            txtnombre3.Visible = True
            txtmaterno.Visible = True
            txtpaterno.Visible = True
            lblgen.Visible = True
            cmbgenero.Visible = True
            lblrfcf.Visible = True
            mtbrfc.Visible = True
        End If
    End Sub

    Private Sub cmbcon_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbcon.SelectedIndexChanged
        If (cmbcon.Text = "PAGADOR") Then
            contacto = True
            ReseteaForm()
            CargaParametros()
            btnbuscarmoral.Visible = True
            lbltipoper.Visible = True
            cmbtipoper.Visible = True
            Conexion.desconectarse()
            Conexion.Consultar("select PROSREL_ID from CRM_PROSREL where PROSREL_PROSID ='" & Id_Bus & "'")
            Conexion.dr.Read()

            If (Conexion.dr.HasRows) Then
                Idcontacto = Conexion.dr.GetInt32(0)
                Conexion.dr.Close()
                Conexion.desconectarse()
                Cargar_Datos("SELECT PRO_ID,isnull(PRO_NOMBRE,''),isnull(PRO_NOMBRE2,''),isnull(PRO_NOMBRE3,''),isnull(PRO_PATERNO,''),isnull(PRO_MATERNO,''),isnull(PRO_GENERO,''), isnull(PRO_TIPOPER,''),isnull(PRO_RFC,''),isnull(PRO_EDOCIVIL,''),isnull(PRO_CALLE,''),isnull(PRO_COLONIA,''),isnull(PRO_CP,''),isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), isnull(PRO_ENTERO,''), RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR,PRO_CLI1, PRO_CLI2,PRO_MOD1, PRO_MOD2,PRO_PAQ1, PRO_PAQ2,PRO_STATUS1, PRO_STATUS2,isnull(PRO_RAZON,'') AS RAZON FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & Idcontacto & "'")
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()            
        ElseIf cmbcon.Text = "PROSPECTO" Then
            ReseteaForm()
            btnbuscarmoral.Visible = False
            txtid.Enabled = True
            Cargar_Datos("SELECT PRO_ID,isnull(PRO_NOMBRE,''),isnull(PRO_NOMBRE2,''),isnull(PRO_NOMBRE3,''),isnull(PRO_PATERNO,''),isnull(PRO_MATERNO,''),isnull(PRO_GENERO,''), isnull(PRO_TIPOPER,''),isnull(PRO_RFC,''),isnull(PRO_EDOCIVIL,''),isnull(PRO_CALLE,''),isnull(PRO_COLONIA,''),isnull(PRO_CP,''),isnull(PRO_CIUDAD,''), isnull(PRO_TELCASA,''), isnull(PRO_TELOFI,''), isnull(PRO_TELCEL,''), isnull(PRO_TELCEL2,''), isnull(PRO_CORREO,''), isnull(PRO_CORREO2,''), isnull(PRO_FORCON,''), isnull(PRO_HRINI,''),isnull(PRO_HRFIN,''), isnull(PRO_ENTERO,''), RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR,PRO_CLI1, PRO_CLI2,PRO_MOD1, PRO_MOD2,PRO_PAQ1, PRO_PAQ2,PRO_STATUS1, PRO_STATUS2,isnull(PRO_RAZON,'') AS RAZON FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID WHERE PRO_ID ='" & Librerias.Id_Bus & "'")
            lbltipoper.Visible = False
            cmbtipoper.Visible = False
        End If
    End Sub
End Class