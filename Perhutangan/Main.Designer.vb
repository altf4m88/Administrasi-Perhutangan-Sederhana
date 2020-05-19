<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.mainTitle = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.subTitle = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.userAddress = New System.Windows.Forms.TextBox()
        Me.debtAmount = New System.Windows.Forms.TextBox()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.unPaid = New System.Windows.Forms.RadioButton()
        Me.paid = New System.Windows.Forms.RadioButton()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.createButton = New System.Windows.Forms.Button()
        Me.dataPicture = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTitle
        '
        Me.mainTitle.AutoSize = True
        Me.mainTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainTitle.ForeColor = System.Drawing.Color.Black
        Me.mainTitle.Location = New System.Drawing.Point(101, 21)
        Me.mainTitle.Name = "mainTitle"
        Me.mainTitle.Size = New System.Drawing.Size(357, 43)
        Me.mainTitle.TabIndex = 0
        Me.mainTitle.Text = "Debt Administration"
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ID.Location = New System.Drawing.Point(31, 30)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(38, 35)
        Me.ID.TabIndex = 1
        Me.ID.Text = "Id"
        '
        'subTitle
        '
        Me.subTitle.AutoSize = True
        Me.subTitle.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.subTitle.Location = New System.Drawing.Point(106, 64)
        Me.subTitle.Name = "subTitle"
        Me.subTitle.Size = New System.Drawing.Size(201, 23)
        Me.subTitle.TabIndex = 2
        Me.subTitle.Text = "With MySql Database"
        '
        'userName
        '
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.userName.Location = New System.Drawing.Point(31, 82)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(341, 35)
        Me.userName.TabIndex = 3
        Me.userName.Text = "Nama"
        '
        'userAddress
        '
        Me.userAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.userAddress.Location = New System.Drawing.Point(31, 137)
        Me.userAddress.Name = "userAddress"
        Me.userAddress.Size = New System.Drawing.Size(341, 35)
        Me.userAddress.TabIndex = 4
        Me.userAddress.Text = "Alamat"
        '
        'debtAmount
        '
        Me.debtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debtAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.debtAmount.Location = New System.Drawing.Point(31, 189)
        Me.debtAmount.Name = "debtAmount"
        Me.debtAmount.Size = New System.Drawing.Size(341, 35)
        Me.debtAmount.TabIndex = 5
        Me.debtAmount.Text = "Jumlah Hutang"
        '
        'dataGrid
        '
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(461, 113)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.RowTemplate.Height = 28
        Me.dataGrid.Size = New System.Drawing.Size(800, 419)
        Me.dataGrid.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateTime)
        Me.GroupBox1.Controls.Add(Me.unPaid)
        Me.GroupBox1.Controls.Add(Me.paid)
        Me.GroupBox1.Controls.Add(Me.userAddress)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.debtAmount)
        Me.GroupBox1.Controls.Add(Me.userName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 353)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'unPaid
        '
        Me.unPaid.AutoSize = True
        Me.unPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unPaid.Location = New System.Drawing.Point(180, 302)
        Me.unPaid.Name = "unPaid"
        Me.unPaid.Size = New System.Drawing.Size(151, 29)
        Me.unPaid.TabIndex = 10
        Me.unPaid.TabStop = True
        Me.unPaid.Text = "Belum Lunas"
        Me.unPaid.UseVisualStyleBackColor = True
        '
        'paid
        '
        Me.paid.AutoSize = True
        Me.paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paid.Location = New System.Drawing.Point(65, 302)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(91, 29)
        Me.paid.TabIndex = 9
        Me.paid.TabStop = True
        Me.paid.Text = "Lunas"
        Me.paid.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.deleteButton.Location = New System.Drawing.Point(325, 474)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(94, 50)
        Me.deleteButton.TabIndex = 8
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.updateButton.Location = New System.Drawing.Point(222, 474)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(97, 50)
        Me.updateButton.TabIndex = 9
        Me.updateButton.Text = " Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'createButton
        '
        Me.createButton.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.createButton.Location = New System.Drawing.Point(122, 474)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(94, 50)
        Me.createButton.TabIndex = 10
        Me.createButton.Text = "Create"
        Me.createButton.UseVisualStyleBackColor = True
        '
        'dataPicture
        '
        Me.dataPicture.Image = Global.Perhutangan.My.Resources.Resources.kisspng_database_scalable_vector_graphics_icon_database_icons_5a776bd2048a31_6876680715177758260186
        Me.dataPicture.Location = New System.Drawing.Point(21, 17)
        Me.dataPicture.Name = "dataPicture"
        Me.dataPicture.Size = New System.Drawing.Size(70, 70)
        Me.dataPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dataPicture.TabIndex = 11
        Me.dataPicture.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.exitButton.Location = New System.Drawing.Point(21, 474)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(94, 50)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.searchBox.Location = New System.Drawing.Point(1078, 52)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(183, 35)
        Me.searchBox.TabIndex = 11
        Me.searchBox.Text = "Search..."
        '
        'dateTime
        '
        Me.dateTime.CustomFormat = "yyyy-MM-dd"
        Me.dateTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTime.Location = New System.Drawing.Point(31, 243)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(341, 35)
        Me.dateTime.TabIndex = 13
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 544)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.dataPicture)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.subTitle)
        Me.Controls.Add(Me.mainTitle)
        Me.MaximumSize = New System.Drawing.Size(1300, 600)
        Me.MinimumSize = New System.Drawing.Size(1300, 600)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainTitle As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents subTitle As Label
    Friend WithEvents userName As TextBox
    Friend WithEvents userAddress As TextBox
    Friend WithEvents debtAmount As TextBox
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents paid As RadioButton
    Friend WithEvents deleteButton As Button
    Friend WithEvents unPaid As RadioButton
    Friend WithEvents updateButton As Button
    Friend WithEvents createButton As Button
    Friend WithEvents dataPicture As PictureBox
    Friend WithEvents exitButton As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents dateTime As DateTimePicker
End Class
