<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        lbFixN1 = New Label()
        lbFixN2 = New Label()
        BtnCom = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Number  1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Number 2"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(191, 69)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(125, 27)
        txtNum1.TabIndex = 2
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(197, 118)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(125, 27)
        txtNum2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(381, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 4
        Label3.Text = "Fix(No 1)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(385, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 5
        Label4.Text = "Fix(No 2)"
        ' 
        ' lbFixN1
        ' 
        lbFixN1.AutoSize = True
        lbFixN1.BackColor = SystemColors.ActiveCaption
        lbFixN1.Location = New Point(470, 79)
        lbFixN1.Name = "lbFixN1"
        lbFixN1.Size = New Size(0, 20)
        lbFixN1.TabIndex = 6
        ' 
        ' lbFixN2
        ' 
        lbFixN2.AutoSize = True
        lbFixN2.Location = New Point(467, 123)
        lbFixN2.Name = "lbFixN2"
        lbFixN2.Size = New Size(0, 20)
        lbFixN2.TabIndex = 7
        ' 
        ' BtnCom
        ' 
        BtnCom.Location = New Point(201, 235)
        BtnCom.Name = "BtnCom"
        BtnCom.Size = New Size(94, 29)
        BtnCom.TabIndex = 8
        BtnCom.Text = "Compute"
        BtnCom.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnCom)
        Controls.Add(lbFixN2)
        Controls.Add(lbFixN1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbFixN1 As Label
    Friend WithEvents lbFixN2 As Label
    Friend WithEvents BtnCom As Button
End Class
