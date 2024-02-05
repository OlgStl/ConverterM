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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()

        Me.FromM = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()

        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()

        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.Btn1.Location = New System.Drawing.Point(203, 311)

        Me.Btn1.Location = New System.Drawing.Point(293, 311)

        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(225, 59)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Convert"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Palace Script MT", 72.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(188, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(260, 89)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Converter"
        '
        'txtFrom
        '

        Me.txtFrom.Location = New System.Drawing.Point(203, 285)



        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(225, 20)
        Me.txtFrom.TabIndex = 1
        '
        'txtTo
        '

        Me.txtTo.Location = New System.Drawing.Point(203, 386)

        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(225, 20)
        Me.txtTo.TabIndex = 3
        '
        'FromM
        '
        Me.FromM.FormattingEnabled = True
        Me.FromM.Location = New System.Drawing.Point(203, 156)
        Me.FromM.Name = "FromM"
        Me.FromM.Size = New System.Drawing.Size(225, 21)
        Me.FromM.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(203, 226)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(225, 20)
        Me.txtPrice.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Playbill", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Market Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Money"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(293, 181)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(225, 20)
        Me.txtPrice.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '

        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(638, 449)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.FromM)

        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.ComboBox1)

        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "00000000000000000000000000000000000000000000"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox

    Friend WithEvents FromM As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents ComboBox1 As ComboBox


    Friend WithEvents ToolStrip1 As ToolStrip

End Class
