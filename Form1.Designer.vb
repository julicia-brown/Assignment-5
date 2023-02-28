<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComicC))
        Me.grpBadge = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutograph = New System.Windows.Forms.RadioButton()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblComic = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.grpBadge.SuspendLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBadge
        '
        Me.grpBadge.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.grpBadge.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBadge.Controls.Add(Me.radConvention)
        Me.grpBadge.Controls.Add(Me.radAutograph)
        Me.grpBadge.Controls.Add(Me.radSuperhero)
        Me.grpBadge.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadge.ForeColor = System.Drawing.Color.IndianRed
        Me.grpBadge.Location = New System.Drawing.Point(157, 598)
        Me.grpBadge.Name = "grpBadge"
        Me.grpBadge.Size = New System.Drawing.Size(718, 235)
        Me.grpBadge.TabIndex = 2
        Me.grpBadge.TabStop = False
        Me.grpBadge.Text = "Select Badge Type:"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(32, 181)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(244, 40)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutograph
        '
        Me.radAutograph.AutoSize = True
        Me.radAutograph.Location = New System.Drawing.Point(32, 111)
        Me.radAutograph.Name = "radAutograph"
        Me.radAutograph.Size = New System.Drawing.Size(483, 40)
        Me.radAutograph.TabIndex = 1
        Me.radAutograph.TabStop = True
        Me.radAutograph.Text = "Convention + Autographs"
        Me.radAutograph.UseVisualStyleBackColor = True
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Location = New System.Drawing.Point(32, 46)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(665, 40)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'picComic
        '
        Me.picComic.Image = CType(resources.GetObject("picComic.Image"), System.Drawing.Image)
        Me.picComic.Location = New System.Drawing.Point(12, 21)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(1053, 327)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 3
        Me.picComic.TabStop = False
        '
        'lblComic
        '
        Me.lblComic.AutoSize = True
        Me.lblComic.Font = New System.Drawing.Font("Comic Sans MS", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComic.ForeColor = System.Drawing.Color.IndianRed
        Me.lblComic.Location = New System.Drawing.Point(70, 368)
        Me.lblComic.Name = "lblComic"
        Me.lblComic.Size = New System.Drawing.Size(891, 82)
        Me.lblComic.TabIndex = 4
        Me.lblComic.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Cooper Black", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.IndianRed
        Me.lblGroupSize.Location = New System.Drawing.Point(307, 487)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(234, 42)
        Me.lblGroupSize.TabIndex = 5
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Cooper Black", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.IndianRed
        Me.txtGroupSize.Location = New System.Drawing.Point(554, 484)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(118, 50)
        Me.txtGroupSize.TabIndex = 6
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalc.Font = New System.Drawing.Font("Comic Sans MS", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(157, 986)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(315, 83)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(589, 986)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(286, 83)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(226, 887)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Registration Cost:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Cooper Black", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.IndianRed
        Me.txtTotal.Location = New System.Drawing.Point(629, 880)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(208, 50)
        Me.txtTotal.TabIndex = 10
        '
        'frmComicC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1081, 1171)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblComic)
        Me.Controls.Add(Me.picComic)
        Me.Controls.Add(Me.grpBadge)
        Me.Name = "frmComicC"
        Me.Text = "Comic Convention Registration"
        Me.grpBadge.ResumeLayout(False)
        Me.grpBadge.PerformLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBadge As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radSuperhero As RadioButton
    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblComic As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
End Class
