<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamResultOPIDUpdate
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOldUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewUserName = New System.Windows.Forms.TextBox()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old UserName/ชื่อผู้ใช้เก่า"
        '
        'txtOldUserName
        '
        Me.txtOldUserName.Location = New System.Drawing.Point(158, 22)
        Me.txtOldUserName.Name = "txtOldUserName"
        Me.txtOldUserName.Size = New System.Drawing.Size(129, 20)
        Me.txtOldUserName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New UserName/ชื่อผู้ใช้ใหม่"
        '
        'txtNewUserName
        '
        Me.txtNewUserName.Location = New System.Drawing.Point(158, 61)
        Me.txtNewUserName.Name = "txtNewUserName"
        Me.txtNewUserName.Size = New System.Drawing.Size(128, 20)
        Me.txtNewUserName.TabIndex = 3
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(310, 34)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(59, 41)
        Me.btUpdate.TabIndex = 4
        Me.btUpdate.Text = "Update อัปเดต"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Yellow
        Me.lblMessage.Location = New System.Drawing.Point(12, 99)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(406, 25)
        Me.lblMessage.TabIndex = 5
        '
        'frmExamResultOPIDUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 133)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.txtNewUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOldUserName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExamResultOPIDUpdate"
        Me.Text = "frmExamResultUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOldUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewUserName As System.Windows.Forms.TextBox
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
