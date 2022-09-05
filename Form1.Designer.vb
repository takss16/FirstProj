<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmiddle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbgender = New System.Windows.Forms.ComboBox()
        Me.cbcourse = New System.Windows.Forms.ComboBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtstudentno = New System.Windows.Forms.TextBox()
        Me.lnlstudentno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student no:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(447, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Middle Initial"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(248, 95)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(183, 24)
        Me.txtlname.TabIndex = 4
        '
        'txtmiddle
        '
        Me.txtmiddle.Location = New System.Drawing.Point(461, 95)
        Me.txtmiddle.Multiline = True
        Me.txtmiddle.Name = "txtmiddle"
        Me.txtmiddle.Size = New System.Drawing.Size(76, 24)
        Me.txtmiddle.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(38, 158)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(498, 29)
        Me.txtaddress.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(229, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Contact no."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Course"
        '
        'cbgender
        '
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbgender.Location = New System.Drawing.Point(36, 211)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(136, 21)
        Me.cbgender.TabIndex = 11
        '
        'cbcourse
        '
        Me.cbcourse.FormattingEnabled = True
        Me.cbcourse.Items.AddRange(New Object() {"BSIT", "BEED", "BS crim", "BSBA", "BSHM"})
        Me.cbcourse.Location = New System.Drawing.Point(399, 211)
        Me.cbcourse.Name = "cbcourse"
        Me.cbcourse.Size = New System.Drawing.Size(136, 21)
        Me.cbcourse.TabIndex = 12
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(232, 211)
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(131, 24)
        Me.txtcontact.TabIndex = 13
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(34, 259)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(501, 152)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtstudentno
        '
        Me.txtstudentno.Location = New System.Drawing.Point(38, 95)
        Me.txtstudentno.Multiline = True
        Me.txtstudentno.Name = "txtstudentno"
        Me.txtstudentno.Size = New System.Drawing.Size(183, 24)
        Me.txtstudentno.TabIndex = 15
        '
        'lnlstudentno
        '
        Me.lnlstudentno.AutoSize = True
        Me.lnlstudentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlstudentno.Location = New System.Drawing.Point(135, 16)
        Me.lnlstudentno.Name = "lnlstudentno"
        Me.lnlstudentno.Size = New System.Drawing.Size(35, 18)
        Me.lnlstudentno.TabIndex = 16
        Me.lnlstudentno.Text = "000"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(758, 463)
        Me.Controls.Add(Me.lnlstudentno)
        Me.Controls.Add(Me.txtstudentno)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.cbcourse)
        Me.Controls.Add(Me.cbgender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmiddle)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtmiddle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbgender As ComboBox
    Friend WithEvents cbcourse As ComboBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtstudentno As TextBox
    Friend WithEvents lnlstudentno As Label
End Class
