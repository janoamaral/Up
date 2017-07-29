<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.chkHTTPS = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numTimeout = New System.Windows.Forms.NumericUpDown()
        Me.numIntervalo = New System.Windows.Forms.NumericUpDown()
        Me.slptMain = New System.Windows.Forms.SplitContainer()
        Me.lstHosts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnOpciones = New System.Windows.Forms.ToolStripButton()
        Me.globalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slptMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slptMain.Panel1.SuspendLayout()
        Me.slptMain.Panel2.SuspendLayout()
        Me.slptMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 374)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(850, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(850, 347)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(850, 374)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.slptMain)
        Me.SplitContainer1.Size = New System.Drawing.Size(850, 347)
        Me.SplitContainer1.SplitterDistance = 205
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.btnAplicar)
        Me.GroupBox1.Controls.Add(Me.chkHTTPS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.numTimeout)
        Me.GroupBox1.Controls.Add(Me.numIntervalo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(205, 347)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(16, 312)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(167, 23)
        Me.btnAplicar.TabIndex = 3
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'chkHTTPS
        '
        Me.chkHTTPS.AutoSize = True
        Me.chkHTTPS.Location = New System.Drawing.Point(20, 113)
        Me.chkHTTPS.Name = "chkHTTPS"
        Me.chkHTTPS.Size = New System.Drawing.Size(101, 17)
        Me.chkHTTPS.TabIndex = 2
        Me.chkHTTPS.Text = "Intentar HTTPS"
        Me.chkHTTPS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Seg."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seg."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Timeout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Intervalo"
        '
        'numTimeout
        '
        Me.numTimeout.Location = New System.Drawing.Point(67, 72)
        Me.numTimeout.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numTimeout.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numTimeout.Name = "numTimeout"
        Me.numTimeout.Size = New System.Drawing.Size(94, 20)
        Me.numTimeout.TabIndex = 1
        Me.numTimeout.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'numIntervalo
        '
        Me.numIntervalo.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numIntervalo.Location = New System.Drawing.Point(67, 39)
        Me.numIntervalo.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.numIntervalo.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numIntervalo.Name = "numIntervalo"
        Me.numIntervalo.Size = New System.Drawing.Size(94, 20)
        Me.numIntervalo.TabIndex = 0
        Me.numIntervalo.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'slptMain
        '
        Me.slptMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slptMain.Location = New System.Drawing.Point(0, 0)
        Me.slptMain.Name = "slptMain"
        Me.slptMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'slptMain.Panel1
        '
        Me.slptMain.Panel1.Controls.Add(Me.lstHosts)
        '
        'slptMain.Panel2
        '
        Me.slptMain.Panel2.Controls.Add(Me.lstHistory)
        Me.slptMain.Size = New System.Drawing.Size(850, 347)
        Me.slptMain.SplitterDistance = 166
        Me.slptMain.TabIndex = 1
        '
        'lstHosts
        '
        Me.lstHosts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstHosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstHosts.FullRowSelect = True
        Me.lstHosts.HideSelection = False
        Me.lstHosts.Location = New System.Drawing.Point(0, 0)
        Me.lstHosts.MultiSelect = False
        Me.lstHosts.Name = "lstHosts"
        Me.lstHosts.Size = New System.Drawing.Size(850, 166)
        Me.lstHosts.TabIndex = 3
        Me.lstHosts.UseCompatibleStateImageBehavior = False
        Me.lstHosts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "HOST"
        Me.ColumnHeader1.Width = 241
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "HTTP"
        Me.ColumnHeader2.Width = 73
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ICMP"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PRUEBAS"
        Me.ColumnHeader4.Width = 82
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "FALLOS"
        '
        'lstHistory
        '
        Me.lstHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader10, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstHistory.FullRowSelect = True
        Me.lstHistory.Location = New System.Drawing.Point(0, 0)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(850, 177)
        Me.lstHistory.TabIndex = 4
        Me.lstHistory.UseCompatibleStateImageBehavior = False
        Me.lstHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "#"
        Me.ColumnHeader6.Width = 47
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "HOST"
        Me.ColumnHeader10.Width = 190
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "HTTP"
        Me.ColumnHeader7.Width = 83
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ICMP"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "HORA"
        Me.ColumnHeader9.Width = 111
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEditar, Me.btnBorrar, Me.ToolStripSeparator6, Me.btnSave, Me.btnOpciones})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(138, 27)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Size = New System.Drawing.Size(24, 24)
        Me.btnAdd.Text = "Agregar"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Padding = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Size = New System.Drawing.Size(24, 24)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.ToolTipText = "Editar el host seleccionado"
        '
        'btnBorrar
        '
        Me.btnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Padding = New System.Windows.Forms.Padding(2)
        Me.btnBorrar.Size = New System.Drawing.Size(24, 24)
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.ToolTipText = "Eliminar el host seleccionado"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(2)
        Me.btnSave.Size = New System.Drawing.Size(24, 24)
        Me.btnSave.Text = "Guardar"
        Me.btnSave.ToolTipText = "Guarda el historial en formato CSV"
        '
        'btnOpciones
        '
        Me.btnOpciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpciones.Image = CType(resources.GetObject("btnOpciones.Image"), System.Drawing.Image)
        Me.btnOpciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Padding = New System.Windows.Forms.Padding(2)
        Me.btnOpciones.Size = New System.Drawing.Size(24, 24)
        Me.btnOpciones.Text = "Configuración"
        Me.btnOpciones.ToolTipText = "Ver / ocultar el panel de configuracion"
        '
        'globalTimer
        '
        Me.globalTimer.Enabled = True
        Me.globalTimer.Interval = 300000
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 17)
        Me.lblStatus.Text = "En espera..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 396)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmMain"
        Me.Text = "Up(s)!"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slptMain.Panel1.ResumeLayout(False)
        Me.slptMain.Panel2.ResumeLayout(False)
        CType(Me.slptMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slptMain.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents globalTimer As Timer
    Friend WithEvents btnBorrar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents slptMain As SplitContainer
    Friend WithEvents lstHosts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lstHistory As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkHTTPS As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numTimeout As NumericUpDown
    Friend WithEvents numIntervalo As NumericUpDown
    Friend WithEvents btnAplicar As Button
    Friend WithEvents btnOpciones As ToolStripButton
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
