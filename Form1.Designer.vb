<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelectPlatter = New System.Windows.Forms.Label()
        Me.radPlatter1 = New System.Windows.Forms.RadioButton()
        Me.radPlatter2 = New System.Windows.Forms.RadioButton()
        Me.radPlatter3 = New System.Windows.Forms.RadioButton()
        Me.radPlatter4 = New System.Windows.Forms.RadioButton()
        Me.radPlatter5 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPayType = New System.Windows.Forms.Label()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPayAtPickup = New System.Windows.Forms.RadioButton()
        Me.lblLoyaltyPoints = New System.Windows.Forms.Label()
        Me.txtLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCostValue = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(89, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(208, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Party Platters"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radPlatter5)
        Me.Panel1.Controls.Add(Me.radPlatter4)
        Me.Panel1.Controls.Add(Me.radPlatter3)
        Me.Panel1.Controls.Add(Me.radPlatter2)
        Me.Panel1.Controls.Add(Me.radPlatter1)
        Me.Panel1.Controls.Add(Me.lblSelectPlatter)
        Me.Panel1.Location = New System.Drawing.Point(93, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 160)
        Me.Panel1.TabIndex = 1
        '
        'lblSelectPlatter
        '
        Me.lblSelectPlatter.AutoSize = True
        Me.lblSelectPlatter.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectPlatter.Location = New System.Drawing.Point(36, 0)
        Me.lblSelectPlatter.Name = "lblSelectPlatter"
        Me.lblSelectPlatter.Size = New System.Drawing.Size(115, 19)
        Me.lblSelectPlatter.TabIndex = 0
        Me.lblSelectPlatter.Text = "Platter Type:"
        '
        'radPlatter1
        '
        Me.radPlatter1.AutoSize = True
        Me.radPlatter1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlatter1.Location = New System.Drawing.Point(4, 24)
        Me.radPlatter1.Name = "radPlatter1"
        Me.radPlatter1.Size = New System.Drawing.Size(164, 20)
        Me.radPlatter1.TabIndex = 1
        Me.radPlatter1.TabStop = True
        Me.radPlatter1.Text = "Ham && Cheese - $28"
        Me.radPlatter1.UseVisualStyleBackColor = True
        '
        'radPlatter2
        '
        Me.radPlatter2.AutoSize = True
        Me.radPlatter2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlatter2.Location = New System.Drawing.Point(4, 50)
        Me.radPlatter2.Name = "radPlatter2"
        Me.radPlatter2.Size = New System.Drawing.Size(182, 20)
        Me.radPlatter2.TabIndex = 2
        Me.radPlatter2.TabStop = True
        Me.radPlatter2.Text = "Turkey && Cheese - $30"
        Me.radPlatter2.UseVisualStyleBackColor = True
        '
        'radPlatter3
        '
        Me.radPlatter3.AutoSize = True
        Me.radPlatter3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlatter3.Location = New System.Drawing.Point(4, 76)
        Me.radPlatter3.Name = "radPlatter3"
        Me.radPlatter3.Size = New System.Drawing.Size(134, 20)
        Me.radPlatter3.TabIndex = 3
        Me.radPlatter3.TabStop = True
        Me.radPlatter3.Text = "Tuna Sald - $40"
        Me.radPlatter3.UseVisualStyleBackColor = True
        '
        'radPlatter4
        '
        Me.radPlatter4.AutoSize = True
        Me.radPlatter4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlatter4.Location = New System.Drawing.Point(3, 102)
        Me.radPlatter4.Name = "radPlatter4"
        Me.radPlatter4.Size = New System.Drawing.Size(164, 20)
        Me.radPlatter4.TabIndex = 4
        Me.radPlatter4.TabStop = True
        Me.radPlatter4.Text = "Chicken Salad - $40"
        Me.radPlatter4.UseVisualStyleBackColor = True
        '
        'radPlatter5
        '
        Me.radPlatter5.AutoSize = True
        Me.radPlatter5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlatter5.Location = New System.Drawing.Point(3, 128)
        Me.radPlatter5.Name = "radPlatter5"
        Me.radPlatter5.Size = New System.Drawing.Size(165, 20)
        Me.radPlatter5.TabIndex = 5
        Me.radPlatter5.TabStop = True
        Me.radPlatter5.Text = "Club Sandwich - $50"
        Me.radPlatter5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radPayAtPickup)
        Me.Panel2.Controls.Add(Me.radPrePay)
        Me.Panel2.Controls.Add(Me.lblPayType)
        Me.Panel2.Location = New System.Drawing.Point(118, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(151, 79)
        Me.Panel2.TabIndex = 2
        '
        'lblPayType
        '
        Me.lblPayType.AutoSize = True
        Me.lblPayType.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayType.Location = New System.Drawing.Point(9, 0)
        Me.lblPayType.Name = "lblPayType"
        Me.lblPayType.Size = New System.Drawing.Size(133, 19)
        Me.lblPayType.TabIndex = 6
        Me.lblPayType.Text = "Payment Type:"
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(4, 22)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(78, 20)
        Me.radPrePay.TabIndex = 6
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPayAtPickup
        '
        Me.radPayAtPickup.AutoSize = True
        Me.radPayAtPickup.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPayAtPickup.Location = New System.Drawing.Point(4, 48)
        Me.radPayAtPickup.Name = "radPayAtPickup"
        Me.radPayAtPickup.Size = New System.Drawing.Size(120, 20)
        Me.radPayAtPickup.TabIndex = 7
        Me.radPayAtPickup.TabStop = True
        Me.radPayAtPickup.Text = "Pay at Pickup"
        Me.radPayAtPickup.UseVisualStyleBackColor = True
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.AutoSize = True
        Me.lblLoyaltyPoints.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(26, 333)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(228, 19)
        Me.lblLoyaltyPoints.TabIndex = 8
        Me.lblLoyaltyPoints.Text = "Loyalty Points to Redeem:"
        '
        'txtLoyaltyPoints
        '
        Me.txtLoyaltyPoints.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyPoints.Location = New System.Drawing.Point(260, 329)
        Me.txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        Me.txtLoyaltyPoints.Size = New System.Drawing.Size(100, 26)
        Me.txtLoyaltyPoints.TabIndex = 9
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(104, 376)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(51, 19)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "Cost:"
        '
        'lblCostValue
        '
        Me.lblCostValue.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostValue.Location = New System.Drawing.Point(161, 376)
        Me.lblCostValue.Name = "lblCostValue"
        Me.lblCostValue.Size = New System.Drawing.Size(108, 19)
        Me.lblCostValue.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(28, 427)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(134, 67)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(202, 427)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 67)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 558)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostValue)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtLoyaltyPoints)
        Me.Controls.Add(Me.lblLoyaltyPoints)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "Party Platters"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radPlatter5 As RadioButton
    Friend WithEvents radPlatter4 As RadioButton
    Friend WithEvents radPlatter3 As RadioButton
    Friend WithEvents radPlatter2 As RadioButton
    Friend WithEvents radPlatter1 As RadioButton
    Friend WithEvents lblSelectPlatter As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radPayAtPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents lblPayType As Label
    Friend WithEvents lblLoyaltyPoints As Label
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCostValue As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
