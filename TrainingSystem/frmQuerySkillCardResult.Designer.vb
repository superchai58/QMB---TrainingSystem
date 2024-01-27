<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuerySkillCardResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSkillCard = New System.Windows.Forms.Button()
        Me.btnClearDefault = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtScheduleID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOPID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.txtTheory = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPicture = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPractice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValiddate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 205)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Query-Skill card result/ตรวจสอบผลของทักษะ"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSkillCard)
        Me.Panel2.Controls.Add(Me.btnClearDefault)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(678, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 185)
        Me.Panel2.TabIndex = 80
        '
        'btnSkillCard
        '
        Me.btnSkillCard.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSkillCard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSkillCard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSkillCard.Location = New System.Drawing.Point(133, 21)
        Me.btnSkillCard.Name = "btnSkillCard"
        Me.btnSkillCard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSkillCard.Size = New System.Drawing.Size(106, 44)
        Me.btnSkillCard.TabIndex = 77
        Me.btnSkillCard.Text = "&Skill-Card"
        Me.btnSkillCard.UseVisualStyleBackColor = False
        '
        'btnClearDefault
        '
        Me.btnClearDefault.BackColor = System.Drawing.SystemColors.Control
        Me.btnClearDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClearDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClearDefault.Location = New System.Drawing.Point(21, 21)
        Me.btnClearDefault.Name = "btnClearDefault"
        Me.btnClearDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClearDefault.Size = New System.Drawing.Size(106, 44)
        Me.btnClearDefault.TabIndex = 78
        Me.btnClearDefault.Text = "&Clear default"
        Me.btnClearDefault.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtResult)
        Me.Panel1.Controls.Add(Me.txtValiddate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtPractice)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtPicture)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTheory)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtScheduleID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtOPID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdQuery)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 185)
        Me.Panel1.TabIndex = 79
        '
        'txtScheduleID
        '
        Me.txtScheduleID.Location = New System.Drawing.Point(99, 111)
        Me.txtScheduleID.Multiline = True
        Me.txtScheduleID.Name = "txtScheduleID"
        Me.txtScheduleID.ReadOnly = True
        Me.txtScheduleID.Size = New System.Drawing.Size(144, 23)
        Me.txtScheduleID.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Schedule NO."
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(300, 82)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(353, 23)
        Me.txtName.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Name"
        '
        'txtOPID
        '
        Me.txtOPID.Location = New System.Drawing.Point(99, 82)
        Me.txtOPID.Multiline = True
        Me.txtOPID.Name = "txtOPID"
        Me.txtOPID.ReadOnly = True
        Me.txtOPID.Size = New System.Drawing.Size(144, 23)
        Me.txtOPID.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "OPID"
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(21, 21)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(203, 44)
        Me.cmdQuery.TabIndex = 76
        Me.cmdQuery.Text = "&Query-Skill card result"
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'DataGV
        '
        Me.DataGV.AllowUserToAddRows = False
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGV.Location = New System.Drawing.Point(0, 205)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGV.Size = New System.Drawing.Size(938, 277)
        Me.DataGV.TabIndex = 40
        '
        'txtTheory
        '
        Me.txtTheory.Location = New System.Drawing.Point(300, 111)
        Me.txtTheory.Multiline = True
        Me.txtTheory.Name = "txtTheory"
        Me.txtTheory.ReadOnly = True
        Me.txtTheory.Size = New System.Drawing.Size(144, 23)
        Me.txtTheory.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Theory"
        '
        'txtPicture
        '
        Me.txtPicture.Location = New System.Drawing.Point(509, 111)
        Me.txtPicture.Multiline = True
        Me.txtPicture.Name = "txtPicture"
        Me.txtPicture.ReadOnly = True
        Me.txtPicture.Size = New System.Drawing.Size(144, 23)
        Me.txtPicture.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(465, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Picture"
        '
        'txtPractice
        '
        Me.txtPractice.Location = New System.Drawing.Point(99, 140)
        Me.txtPractice.Multiline = True
        Me.txtPractice.Name = "txtPractice"
        Me.txtPractice.ReadOnly = True
        Me.txtPractice.Size = New System.Drawing.Size(144, 23)
        Me.txtPractice.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Practice"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(300, 140)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(144, 23)
        Me.txtResult.TabIndex = 92
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(259, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Result"
        '
        'txtValiddate
        '
        Me.txtValiddate.Location = New System.Drawing.Point(509, 140)
        Me.txtValiddate.Multiline = True
        Me.txtValiddate.Name = "txtValiddate"
        Me.txtValiddate.ReadOnly = True
        Me.txtValiddate.Size = New System.Drawing.Size(144, 23)
        Me.txtValiddate.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(454, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Validdate"
        '
        'frmQuerySkillCardResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 482)
        Me.Controls.Add(Me.DataGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuerySkillCardResult"
        Me.Text = "frmQuerySkillCardResult[20231026]"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents cmdQuery As Button
    Friend WithEvents DataGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Public WithEvents btnSkillCard As Button
    Public WithEvents btnClearDefault As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtScheduleID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOPID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtValiddate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPractice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPicture As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTheory As TextBox
    Friend WithEvents Label4 As Label
End Class
