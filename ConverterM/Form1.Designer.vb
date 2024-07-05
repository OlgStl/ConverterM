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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnFetchRates = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(85, 322)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(225, 59)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Convert"
        Me.Btn1.UseVisualStyleBackColor = True
        Me.Btn1.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Palace Script MT", 72.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(219, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(260, 89)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Converter"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(234, 285)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(225, 20)
        Me.txtFrom.TabIndex = 1
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(234, 397)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(225, 20)
        Me.txtTo.TabIndex = 3
        '
        'FromM
        '
        Me.FromM.FormattingEnabled = True
        Me.FromM.Location = New System.Drawing.Point(234, 156)
        Me.FromM.Name = "FromM"
        Me.FromM.Size = New System.Drawing.Size(225, 21)
        Me.FromM.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(234, 217)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(225, 20)
        Me.txtPrice.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Playbill", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Exchange Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 124)
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
        Me.Label4.Location = New System.Drawing.Point(306, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Money"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 11
        '
        'BtnFetchRates
        '
        Me.BtnFetchRates.Location = New System.Drawing.Point(361, 322)
        Me.BtnFetchRates.Name = "BtnFetchRates"
        Me.BtnFetchRates.Size = New System.Drawing.Size(209, 59)
        Me.BtnFetchRates.TabIndex = 13
        Me.BtnFetchRates.Text = "Button1"
        Me.BtnFetchRates.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnFetchRates)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FromM)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Currancy Converter"
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
    Friend WithEvents BtnFetchRates As Button
End Class
