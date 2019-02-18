<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class search_record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search_record))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.l1srch_rcrd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_enrol_no = New System.Windows.Forms.TextBox()
        Me.t_stud_name = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(663, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 36)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Exit from Library !"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'l1srch_rcrd
        '
        Me.l1srch_rcrd.AutoSize = True
        Me.l1srch_rcrd.BackColor = System.Drawing.Color.Transparent
        Me.l1srch_rcrd.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1srch_rcrd.Location = New System.Drawing.Point(233, 32)
        Me.l1srch_rcrd.Name = "l1srch_rcrd"
        Me.l1srch_rcrd.Size = New System.Drawing.Size(306, 42)
        Me.l1srch_rcrd.TabIndex = 6
        Me.l1srch_rcrd.Text = "Search Student's Record"
        Me.l1srch_rcrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter Student's Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter Student's Name"
        '
        't_enrol_no
        '
        Me.t_enrol_no.Location = New System.Drawing.Point(382, 162)
        Me.t_enrol_no.Name = "t_enrol_no"
        Me.t_enrol_no.Size = New System.Drawing.Size(219, 20)
        Me.t_enrol_no.TabIndex = 9
        '
        't_stud_name
        '
        Me.t_stud_name.Location = New System.Drawing.Point(382, 224)
        Me.t_stud_name.Multiline = True
        Me.t_stud_name.Name = "t_stud_name"
        Me.t_stud_name.Size = New System.Drawing.Size(219, 20)
        Me.t_stud_name.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(279, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'search_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.t_stud_name)
        Me.Controls.Add(Me.t_enrol_no)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l1srch_rcrd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "search_record"
        Me.Text = "search_record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents l1srch_rcrd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_enrol_no As TextBox
    Friend WithEvents t_stud_name As TextBox
    Friend WithEvents Button2 As Button
End Class
